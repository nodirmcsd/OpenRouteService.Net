using System;
using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.PostDirectionResponseModels
{
    public class Engine
    {
        [JsonProperty("build_date")]
        public DateTime BuildDate { get; set; }

        [JsonProperty("graph_date")]
        public DateTime GraphDate { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }
    }
}