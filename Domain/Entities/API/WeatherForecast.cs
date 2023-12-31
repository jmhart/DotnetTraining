using System.Text.Json.Serialization;

namespace Domain.Entities.API
{
    public class WeatherForecast
    {
        public string Date { get; init; }
        public double High { get; set; }
        public double Low { get; set; }

        public WeatherForecast(string date)
        {
            Date = date;
        }
    }
}