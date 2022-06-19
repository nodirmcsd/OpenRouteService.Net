using System;
using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class GeoCoding
    {
        [JsonProperty("attribution")]
        public Uri? Attribution { get; set; }

        [JsonProperty("engine")]
        public Engine? Engine { get; set; }

        [JsonProperty("query")]
        public Query? Query { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }
    }
}