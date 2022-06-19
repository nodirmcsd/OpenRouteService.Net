using System.Globalization;
using System.Threading.Tasks;
using OpenRouteService.App.Enums;
using OpenRouteService.App.Models;
using OpenRouteService.App.Requests;
using OpenRouteService.App.Responses;

namespace OpenRouteService.App
{
    public interface IOpenRouteServiceClient
    {
        Task<GeoCodeResponse> Geocode(CountryType country, string text, CultureInfo language);

        Task<GetDirectionResponse> GetDirections(ProfileType profile, Location start, Location end,
            CultureInfo language);

        Task<PostDirectionResponse> PostDirections(ProfileType profile, DirectionParameter parameters);
    }
}