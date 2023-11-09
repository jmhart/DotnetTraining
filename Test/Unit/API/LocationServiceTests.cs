using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Infra.API.Interfaces;
using Infra.API.Services;

namespace Unit.API
{
    public class LocationServiceTests
    {
        private readonly ILocationService locationService;

        public LocationServiceTests()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://nominatim.openstreetmap.org/"),
            };
            httpClient.DefaultRequestHeaders.Add("User-Agent", "DemoAPI");

            locationService = new LocationService(httpClient);
        }

        [Fact]
        public async Task GetLocationSuccess()
        {
            var location = await locationService.GetLocationAsync("Minneapolis", "MN");

            location.Should().NotBeNull("because a location should be found");
        }
    }
}