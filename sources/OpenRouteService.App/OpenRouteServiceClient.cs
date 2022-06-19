using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using OpenRouteService.App.Enums;
using OpenRouteService.App.Exceptions;
using OpenRouteService.App.Extensions;
using OpenRouteService.App.Models;
using OpenRouteService.App.Requests;
using OpenRouteService.App.Responses;

namespace OpenRouteService.App
{
    public class OpenRouteServiceClient : BaseServiceClient, IOpenRouteServiceClient
    {
        public OpenRouteServiceClient(OpenRouteServiceSettings settings) : base(settings)
        {
            _settings = settings;
        }

        private readonly OpenRouteServiceSettings _settings;


        public async Task<GeoCodeResponse> Geocode(CountryType country, string text, CultureInfo language)
        {
            var parameters = new Dictionary<string, string>
            {
                { "text", text?.Trim() ?? string.Empty },
                { "boundary.country", country.GetStringValue() },
                { "lang", language.Name.ToLowerInvariant() ?? "ru-ru" }
            };
            var uri = GetUriWithAuth("/geocode/search", parameters);
            using var client = GetHttpClient(false);
            var response = await client.GetAsync(uri);
            if (!response.IsSuccessStatusCode) throw new ExternalServiceException($"{uri.AbsoluteUri}");
            var result = await ParseAsync<GeoCodeResponse>(response);
            return result;
        }

        public async Task<GetDirectionResponse> GetDirections(ProfileType profile, Location start, Location end,
            CultureInfo language)
        {
            var parameters = new Dictionary<string, string>
            {
                { "start", start.ToString() },
                { "end", end.ToString() },
                { "lang", language.Name.ToLowerInvariant() ?? "ru-ru" }
            };
            var uri = GetUriWithAuth($"v2/directions/{profile.GetStringValue()}", parameters);
            using var client = GetHttpClient(false);
            var response = await client.GetAsync(uri);
            if (!response.IsSuccessStatusCode) throw new ExternalServiceException($"{uri.AbsoluteUri}");
            var result = await ParseAsync<GetDirectionResponse>(response);
            return result;
        }

        public async Task<PostDirectionResponse> PostDirections(ProfileType profile, DirectionParameter parameters)
        {
            using var client = GetHttpClient(true);
            var uri = new Uri($"{_settings.BaseUrl}/v2/directions/{profile.GetStringValue()}");
            var request = new DirectionRequest
            {
                Coordinates = new List<List<double>>(),
                Instructions = parameters.Instructions,
                InstructionsFormat = parameters.InstructionsFormat.GetStringValue(),
                Language = parameters.Language?.Name.ToLowerInvariant() ?? "ru-ru",
                MaximumSpeed = parameters.MaximumSpeed,
                Preference = parameters.Preference.GetStringValue(),
                Units = parameters.Units.GetStringValue()
            };
            request.Coordinates.Add(parameters.Start?.ToArray().ToList() ?? new List<double>());
            request.Coordinates.Add(parameters.End?.ToArray().ToList() ?? new List<double>());
            var response = await client.PostAsync(uri, Serialize(request));
            if (!response.IsSuccessStatusCode) throw new ExternalServiceException($"{uri.AbsoluteUri}");
            var result = await ParseAsync<PostDirectionResponse>(response);
            return result;
        }
    }
}