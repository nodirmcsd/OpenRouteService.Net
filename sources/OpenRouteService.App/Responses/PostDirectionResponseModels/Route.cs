using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.PostDirectionResponseModels
{
    public class Route
    {
        [JsonProperty("bbox")]
        public double[]? BBox { get; set; }

        [JsonProperty("geometry")]
        public string? Geometry { get; set; }

        [JsonProperty("segments")]
        public Segment[]? Segments { get; set; }

        [JsonProperty("summary")]
        public Summary? Summary { get; set; }

        [JsonProperty("way_points")]
        public long[]? WayPoints { get; set; }
    }
}