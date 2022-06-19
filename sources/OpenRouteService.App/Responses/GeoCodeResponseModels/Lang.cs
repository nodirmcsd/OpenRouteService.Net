using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class Lang
    {
        [JsonProperty("defaulted")]
        public bool Defaulted { get; set; }

        [JsonProperty("iso6391")]
        public string? Iso6391 { get; set; }

        [JsonProperty("iso6393")]
        public string? Iso6393 { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("via")]
        public string? Via { get; set; }
    }
}