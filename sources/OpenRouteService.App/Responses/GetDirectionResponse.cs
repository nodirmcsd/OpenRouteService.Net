using Newtonsoft.Json;
using OpenRouteService.App.Responses.GetDirectionResponseModels;
using Metadata = OpenRouteService.App.Responses.PostDirectionResponseModels.Metadata;

namespace OpenRouteService.App.Responses
{
    public class GetDirectionResponse
    {
        [JsonProperty("bbox")]
        public double[]? BBox { get; set; }

        [JsonProperty("features")]
        public Feature[]? Features { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}