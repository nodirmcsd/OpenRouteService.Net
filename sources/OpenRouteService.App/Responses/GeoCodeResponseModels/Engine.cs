using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class Engine
    {
        [JsonProperty("author")]
        public string? Author { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }
    }
}