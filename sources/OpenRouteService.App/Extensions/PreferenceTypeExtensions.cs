using OpenRouteService.App.Enums;

namespace OpenRouteService.App.Extensions
{
    public static class PreferenceTypeExtensions
    {
        public static string GetStringValue(this PreferenceType enumValue)
        {
            return enumValue switch
            {
                PreferenceType.Fastest => "fastest",
                PreferenceType.Recommended => "recommended",
                PreferenceType.Shortest => "shortest",
                _ => "fastest"
            };
        }
    }
}