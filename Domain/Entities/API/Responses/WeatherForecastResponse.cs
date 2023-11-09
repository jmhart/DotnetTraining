using Infra.API.Models;

namespace Domain.Entities.API.Responses
{
    public class WeatherForecastResponse
    {
        public List<WeatherForecast> WeatherForecast { get; set; } = new();
    }
}