using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Infra.API.Interfaces;
using Infra.API.Services;

namespace Unit.API
{
    public class WeatherServiceTests
    {
        private readonly IWeatherService weatherService;
        public WeatherServiceTests()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.open-meteo.com/v1/"),
            };

            weatherService = new WeatherService(httpClient);
        }

        [Fact]
        public async Task GetWeatherSuccess()
        {
            var forecast = await weatherService.GetWeatherAsync(44.98, 93.2638);

            forecast.Should().NotBeNull("because a weather should be found");
        }
    }
}