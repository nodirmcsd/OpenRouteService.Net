namespace OpenRouteService.App
{
    public class OpenRouteServiceSettings
    {
        public OpenRouteServiceSettings()
        {
        }

        public OpenRouteServiceSettings(string? apiKey)
        {
            ApiKey = apiKey;
        }

        public string? ApiKey { get; set; } = "5b3ce3597851110001cf624838e078d7a9e3422c87dc1edc6c5004da";
        public string? BaseUrl { get; set; } = "https://api.openrouteservice.org";
    }
}