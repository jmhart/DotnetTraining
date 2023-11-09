using System.Text.Json.Serialization;

namespace Infra.API.Models
{
    public class WeatherForecast
    {
        [JsonPropertyName("daily")]
        public DailyTemperature? DailyTemperature { get; init; }
    }
}