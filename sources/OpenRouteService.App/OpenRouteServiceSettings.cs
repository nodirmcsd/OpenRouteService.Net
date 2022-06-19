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

        public string? ApiKey { get; set; } = "";
        public string? BaseUrl { get; set; } = "https://api.openrouteservice.org";
    }
}