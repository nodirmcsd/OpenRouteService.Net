using System.Globalization;
using OpenRouteService.App.Enums;
using OpenRouteService.App.Models;

namespace OpenRouteService.App.Requests
{
    public class DirectionParameter
    {
        public Location? End { get; set; }
        public bool Instructions { get; set; }
        public InstructionsType InstructionsFormat { get; set; }
        public CultureInfo? Language { get; set; } = new CultureInfo("ru-RU");
        public long MaximumSpeed { get; set; }
        public PreferenceType Preference { get; set; }
        public Location? Start { get; set; }
        public UnitType Units { get; set; }
    }
}