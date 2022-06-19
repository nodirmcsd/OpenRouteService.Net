using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.PostDirectionResponseModels
{
    public class Summary
    {
        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }
    }
}