using OpenRouteService.App.Enums;

namespace OpenRouteService.App.Extensions
{
    public static class UnitTypeExtensions
    {
        public static string GetStringValue(this UnitType enumValue)
        {
            return enumValue switch
            {
                UnitType.Meters => "m",
                UnitType.Kilometers => "km",
                UnitType.Miles => "mi",
                _ => "m"
            };
        }
    }
}