using OpenRouteService.App.Enums;

namespace OpenRouteService.App.Extensions
{
    public static class InstructionsTypeExtensions
    {
        public static string GetStringValue(this InstructionsType enumValue)
        {
            return enumValue switch
            {
                InstructionsType.Html => "html",
                InstructionsType.Text => "text",
                _ => "text"
            };
        }
    }
}