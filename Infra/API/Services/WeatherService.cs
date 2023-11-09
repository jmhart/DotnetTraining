using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.API.Interfaces;

namespace Infra.API.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient httpClient;

        public WeatherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


    }
}