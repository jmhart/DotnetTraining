using System.Text.Json.Serialization;

namespace Domain.Entities.API
{
    public class WeatherData
    {
        [JsonPropertyName("daily")]
        public DailyTemperature DailyTemperature { get; init; } = new();
    }
}