using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OpenRouteService.App.Exceptions;

namespace OpenRouteService.App
{
    public abstract class BaseServiceClient
    {
        protected BaseServiceClient(OpenRouteServiceSettings settings)
        {
            _settings = settings;
        }


        protected readonly JsonSerializerSettings? CamelCase = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        private readonly OpenRouteServiceSettings _settings;

        protected HttpClient GetHttpClient(bool setHeaders)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            if (setHeaders)
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_settings.ApiKey);
            }

            httpClient.DefaultRequestHeaders.Add("User-Agent", typeof(OpenRouteServiceClient).FullName);
            return httpClient;
        }


        protected Uri GetUriWithAuth(string urlPath, Dictionary<string, string> urlParameters)
        {
            var url = $"{_settings.BaseUrl}/{urlPath.Replace("//", "/")}";
            var retVal = new Uri(url);
            var httpValueCollection = HttpUtility.ParseQueryString(retVal.Query);
            if (urlParameters.Any())
                foreach (var (key, value) in urlParameters)
                {
                    httpValueCollection.Remove(key);
                    httpValueCollection.Add(key, value);
                }

            httpValueCollection.Remove("api_key");
            httpValueCollection.Add("api_key", _settings.ApiKey);
            var uriBuilder = new UriBuilder(retVal)
            {
                Query = httpValueCollection.ToString()
            };
            return uriBuilder.Uri;
        }

        protected async Task<T> ParseAsync<T>(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<T>(body, CamelCase) ?? Activator.CreateInstance<T>();
            var exception = new JsonParsingException("Json is not valid")
            {
                HttpStatus = response.StatusCode,
                BodyText = body
            };
            throw exception;
        }

        protected HttpContent Serialize<T>(T entity)
        {
            var jsonString = JsonConvert.SerializeObject(entity, CamelCase);
            return new StringContent(jsonString, Encoding.UTF8, "application/json");
        }
    }
}