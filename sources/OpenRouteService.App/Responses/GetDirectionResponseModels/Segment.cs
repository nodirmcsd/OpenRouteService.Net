using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GetDirectionResponseModels
{
    public class Segment
    {
        [JsonProperty("distance")]
        public double? Distance { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("steps")]
        public Step[]? Steps { get; set; }
    }
}