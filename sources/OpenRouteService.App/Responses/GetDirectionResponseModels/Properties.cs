using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GetDirectionResponseModels
{
    public class Properties
    {
        [JsonProperty("segments")]
        public Segment[]? Segments { get; set; }

        [JsonProperty("summary")]
        public Summary? Summary { get; set; }

        [JsonProperty("way_points")]
        public long[]? WayPoints { get; set; }
    }
}