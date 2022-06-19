using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class Geometry
    {
        [JsonProperty("coordinates")]
        public double[]? Coordinates { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}