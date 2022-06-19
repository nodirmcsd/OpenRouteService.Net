using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GetDirectionResponseModels
{
    public class Feature
    {
        [JsonProperty("bbox")]
        public double[]? BBox { get; set; }

        [JsonProperty("geometry")]
        public Geometry? Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties? Properties { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}