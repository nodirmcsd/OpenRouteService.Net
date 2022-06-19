using OpenRouteService.App.Enums;

namespace OpenRouteService.App.Extensions
{
    public static class CountryTypeExtensions
    {
        public static string GetStringValue(this CountryType enumValue)
        {
            return enumValue switch
            {
                CountryType.Ru => "RU",
                CountryType.Ua => "UA",
                CountryType.Uz => "UZ",
                CountryType.By => "BY",
                CountryType.Kz => "KZ",
                CountryType.Kg => "KG",
                _ => "RU"
            };
        }
    }
}