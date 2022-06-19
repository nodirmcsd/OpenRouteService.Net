using Newtonsoft.Json;
using OpenRouteService.App.Responses.PostDirectionResponseModels;

namespace OpenRouteService.App.Responses
{
    public class PostDirectionResponse
    {
        [JsonProperty("bbox")]
        public double[]? BBox { get; set; }

        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonProperty("routes")]
        public Route[]? Routes { get; set; }
    }
}