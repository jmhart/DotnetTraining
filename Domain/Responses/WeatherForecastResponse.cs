using Domain.Entities.API;

namespace Domain.Responses
{
    public class WeatherForecastResponse
    {
        public List<WeatherForecast> WeatherForecast { get; set; } = new();
    }
}