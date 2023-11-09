using System.Text.Json.Serialization;


namespace Infra.API.Models
{
    public class Location
    {
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; init; }

        [JsonPropertyName("lat")]
        public string? Lat { private get; init; }

        [JsonPropertyName("lon")]
        public string? Long { private get; init; }

        public double Latitude => double.Parse(Lat!);

        public double Longitude => double.Parse(Long!);
    }
}