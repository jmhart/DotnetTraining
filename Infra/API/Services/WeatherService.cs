using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using Infra.API.Interfaces;
using Infra.API.Models;

namespace Infra.API.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient httpClient;

        public WeatherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherData?> GetWeatherAsync(double latitude, double longtitude)
        {
            string query = $"forecast?latitude={latitude}&longitude=-{longtitude}&daily=temperature_2m_max,temperature_2m_min&temperature_unit=fahrenheit&wind_speed_unit=mph";
            var weatherData = await httpClient.GetFromJsonAsync<WeatherData>($"{query}");

            return weatherData;
        }

        public List<WeatherForecast> GetWeatherForecast(WeatherData weatherData)
        {
            // TODO: Pick up here.
            throw new NotImplementedException();
        }
    }
}