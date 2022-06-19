using System;
using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GetDirectionResponseModels
{
    public class Engine
    {
        [JsonProperty("build_date")]
        public DateTimeOffset BuildDate { get; set; }

        [JsonProperty("graph_date")]
        public DateTimeOffset GraphDate { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }
    }
}