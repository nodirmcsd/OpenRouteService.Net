using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenRouteService.App.Requests
{
    public class DirectionRequest
    {
        [JsonProperty("coordinates")]
        public List<List<double>> Coordinates { get; set; } = new List<List<double>>();

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

        [JsonProperty("units")]
        public string? Units { get; set; }
    }
}