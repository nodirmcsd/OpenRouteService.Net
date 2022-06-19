using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class Feature
    {
        [JsonProperty("geometry")]
        public Geometry? Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties? Properties { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}