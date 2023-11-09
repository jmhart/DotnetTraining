using Infra.API.Interfaces;
using Infra.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationsController(ILocationService locationService)
        {
            this.locationService = locationService;

        }

        // TODO: see about add validation attributes if time permits.
        [HttpGet("{city}/{state}")]
        public async Task<ActionResult<Location>> Get(string city, string state)
        {
            if (string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state))
            {
                return BadRequest();
            }

            var location = await locationService.GetLocationAsync(city, state);
            if (location is null)
            {
                return NoContent();
            }

            return Ok(location);
        }
    }
}