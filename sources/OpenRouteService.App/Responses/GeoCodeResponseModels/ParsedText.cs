using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class ParsedText
    {
        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("housenumber")]
        public string? HouseNumber { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }
    }
}