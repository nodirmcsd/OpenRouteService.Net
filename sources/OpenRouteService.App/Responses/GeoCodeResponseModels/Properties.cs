using Newtonsoft.Json;

namespace OpenRouteService.App.Responses.GeoCodeResponseModels
{
    public class Properties
    {
        [JsonProperty("accuracy")]
        public string? Accuracy { get; set; }

        [JsonProperty("confidence")]
        public double? Confidence { get; set; }

        [JsonProperty("continent")]
        public string? Continent { get; set; }

        [JsonProperty("continent_gid")]
        public string? ContinentGid { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("country_a")]
        public string? CountryA { get; set; }

        [JsonProperty("country_gid")]
        public string? CountryGid { get; set; }

        [JsonProperty("county")]
        public string? County { get; set; }

        [JsonProperty("county_gid")]
        public string? CountyGid { get; set; }

        [JsonProperty("gid")]
        public string? Gid { get; set; }

        [JsonProperty("housenumber")]
        public long? HouseNumber { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("layer")]
        public string? Layer { get; set; }

        [JsonProperty("match_type")]
        public string? MatchType { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("region")]
        public string? Region { get; set; }

        [JsonProperty("region_a")]
        public string? RegionA { get; set; }

        [JsonProperty("region_gid")]
        public string? RegionGid { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("source_id")]
        public string? SourceId { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }
    }
}