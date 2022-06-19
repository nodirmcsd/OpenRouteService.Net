using System.Globalization;
using Newtonsoft.Json;
using OpenRouteService.App;
using OpenRouteService.App.Enums;
using OpenRouteService.App.Models;
using OpenRouteService.App.Requests;

namespace OpenRouteService.Tests;

[TestClass]
public class OpenRouteServiceClientTests
{
    [TestMethod]
    public void TestGeocode()
    {
        IOpenRouteServiceClient client = new OpenRouteServiceClient(new OpenRouteServiceSettings());
        var result = client.Geocode(CountryType.Ru, "Москва, Лаптева 4, 97", new CultureInfo("ru-RU"))
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();
        Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }

    [TestMethod]
    public void TestGetDirections()
    {
        IOpenRouteServiceClient client = new OpenRouteServiceClient(new OpenRouteServiceSettings());
        var path = client.GetDirections(ProfileType.DrivingCar,
                new Location(55.600694, 37.366484),
                new Location(55.683376, 37.574112), new CultureInfo("ru-RU"))
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();
        Console.WriteLine(JsonConvert.SerializeObject(path, Formatting.Indented));
    }

    [TestMethod]
    public void TestPostDirections()
    {
        IOpenRouteServiceClient client = new OpenRouteServiceClient(new OpenRouteServiceSettings());
        var path = client.PostDirections(ProfileType.DrivingCar,
                new DirectionParameter
                {
                    Start = new Location(55.600694, 37.366484),
                    End = new Location(55.683376, 37.574112),
                    Instructions = true,
                    InstructionsFormat = InstructionsType.Text,
                    Language = new CultureInfo("ru-RU"),
                    MaximumSpeed = 80,
                    Preference = PreferenceType.Recommended,
                    Units = UnitType.Meters
                })
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();
        Console.WriteLine(JsonConvert.SerializeObject(path, Formatting.Indented));
    }
}