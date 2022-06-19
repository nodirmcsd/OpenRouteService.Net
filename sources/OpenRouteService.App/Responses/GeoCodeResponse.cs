using Newtonsoft.Json;
using OpenRouteService.App.Responses.GeoCodeResponseModels;

namespace OpenRouteService.App.Responses
{
    public class GeoCodeResponse
    {
        [JsonProperty("bbox")]
        public double[]? BBox { get; set; }

        [JsonProperty("features")]
        public Feature[]? Features { get; set; }

        [JsonProperty("geocoding")]
        public GeoCoding? GeoCoding { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}