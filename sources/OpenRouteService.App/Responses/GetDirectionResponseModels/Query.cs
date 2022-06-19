using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GetDirectionResponseModels
{
    public class Query
    {
        [JsonProperty("coordinates")]
        public double[][]? Coordinates { get; set; }

        [JsonProperty("format")]
        public string? Format { get; set; }

        [JsonProperty("profile")]
        public string? Profile { get; set; }
    }
}