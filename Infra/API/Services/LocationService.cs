using System.Net.Http.Json;
using Domain.Entities.API;
using Infra.API.Interfaces;


namespace Infra.API.Services
{
    public class LocationService : ILocationService
    {
        private readonly HttpClient httpClient;

        public LocationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Location?> GetLocationAsync(string city, string state)
        {
            string query = $"city={city}&state={state}&format=json";
            var locations = await httpClient.GetFromJsonAsync<List<Location>>($"search?{query}");

            return locations?.FirstOrDefault();
        }
    }
}