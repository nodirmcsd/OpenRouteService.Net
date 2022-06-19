using OpenRouteService.App.Enums;

namespace OpenRouteService.App.Extensions
{
    public static class ProfileTypeExtensions
    {
        public static string GetStringValue(this ProfileType enumValue)
        {
            return enumValue switch
            {
                ProfileType.DrivingCar => "driving-car",
                ProfileType.DrivingHgv => "driving-hgv",
                ProfileType.CyclingRegular => "cycling-regular",
                ProfileType.CyclingRoad => "cycling-road",
                ProfileType.CyclingMountain => "cycling-mountain",
                ProfileType.CyclingElectric => "cycling-electric",
                ProfileType.FootWalking => "foot-walking",
                ProfileType.FootHiking => "foot-hiking",
                ProfileType.Wheelchair => "wheelchair",
                _ => "driving-car"
            };
        }
    }
}