
using Domain.Entities.API;

namespace Infra.API.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherData?> GetWeatherAsync(double latitude, double longtitude);
        List<WeatherForecast> GetWeatherForecast(WeatherData weatherData);
    }
}