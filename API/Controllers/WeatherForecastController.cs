using Domain.Entities.API.Responses;
using Infra.API.Interfaces;
using Infra.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly IWeatherService weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        this.weatherService = weatherService;
    }

    [HttpGet("{latitude}/{longitude}")]
    public async Task<ActionResult<WeatherForecastResponse>> Get(double latitude, double longitude)
    {
        var weatherData = await weatherService.GetWeatherAsync(latitude, longitude);

        if (weatherData is null)
        {
            return BadRequest();
        }

        var weatherForecasts = weatherService.GetWeatherForecast(weatherData);
        var response = new WeatherForecastResponse
        {
            WeatherForecast = weatherForecasts
        };

        return Ok(response);
    }
}
