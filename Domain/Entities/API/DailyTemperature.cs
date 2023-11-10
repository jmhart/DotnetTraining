using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.API
{
    public class DailyTemperature
    {
        [JsonPropertyName("time")]
        public List<string> Dates { get; init; } = new();

        [JsonPropertyName("temperature_2m_min")]
        public List<double> MinimumTemperatures { get; init; } = new();

        [JsonPropertyName("temperature_2m_max")]
        public List<double> MaxTemperatures { get; init; } = new();
    }
}