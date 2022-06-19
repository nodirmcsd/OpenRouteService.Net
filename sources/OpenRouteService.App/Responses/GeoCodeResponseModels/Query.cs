using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class Query
    {
        [JsonProperty("boundary.country")]
        public string[]? BoundaryCountry { get; set; }

        [JsonProperty("lang")]
        public Lang? Lang { get; set; }

        [JsonProperty("parsed_text")]
        public ParsedText? ParsedText { get; set; }

        [JsonProperty("parser")]
        public string? Parser { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("querySize")]
        public long? QuerySize { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("text")]
        public string? Text { get; set; }
    }
}