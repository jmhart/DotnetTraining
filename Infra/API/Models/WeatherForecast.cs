using System.Text.Json.Serialization;

namespace Infra.API.Models
{
    public class WeatherForecast
    {
        public string Date { get; init; }
        public double High { get; set; }
        public double Low { get; set; }

        public WeatherForecast(string date)
        {
            this.Date = date;
        }

    }
}