using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GetDirectionResponseModels
{
    public class Step
    {
        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("instruction")]
        public string? Instruction { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("way_points")]
        public long[]? WayPoints { get; set; }
    }
}