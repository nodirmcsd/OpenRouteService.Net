using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.PostDirectionResponseModels
{
    public class Metadata
    {
        [JsonProperty("attribution")]
        public string? Attribution { get; set; }

        [JsonProperty("engine")]
        public Engine? Engine { get; set; }

        [JsonProperty("query")]
        public Query? Query { get; set; }

        [JsonProperty("service")]
        public string? Service { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}