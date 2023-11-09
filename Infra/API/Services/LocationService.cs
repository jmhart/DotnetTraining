using System.Net.Http.Json;
using Infra.API.Interfaces;
using Infra.API.Models;

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
            httpClient.DefaultRequestHeaders.Add("Accept", "text/plain");
            var response = await httpClient.GetAsync($"search?{query}");

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

            var location = await response.Content.ReadFromJsonAsync<Location>();

            return location;
        }
    }
}