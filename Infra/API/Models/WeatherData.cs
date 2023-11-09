using System.Text.Json.Serialization;

namespace Infra.API.Models
{
    public class WeatherData
    {
        [JsonPropertyName("daily")]
        public DailyTemperature? DailyTemperature { get; init; }
    }
}