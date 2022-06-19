using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.PostDirectionResponseModels
{
    public class Query
    {
        [JsonProperty("coordinates")]
        public double[][]? Coordinates { get; set; }

        [JsonProperty("format")]
        public string? Format { get; set; }

        [JsonProperty("instructions")]
        public bool Instructions { get; set; }

        [JsonProperty("instructions_format")]
        public string? InstructionsFormat { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("maximum_speed")]
        public long MaximumSpeed { get; set; }

        [JsonProperty("preference")]
        public string? Preference { get; set; }

        [JsonProperty("profile")]
        public string? Profile { get; set; }

        [JsonProperty("units")]
        public string? Units { get; set; }
    }
}