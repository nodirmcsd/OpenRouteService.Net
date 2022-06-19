using System.Globalization;

namespace OpenRouteService.App.Models
{
    public class Location
    {
        public Location()
        {
        }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double[] ToArray()
        {
            return new[] { Longitude, Latitude };
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0:F10},{1:F10}", Longitude, Latitude);
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}