using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infra.API.Models
{
    public class DailyTemperature
    {
        [JsonPropertyName("time")]
        public string[]? Dates { get; init; }

        [JsonPropertyName("temperature_2m_min")]
        public double[]? MinimumTemperatures { get; init; }

        [JsonPropertyName("temperature_2m_max")]
        public double[]? MaxTemperatures { get; init; }
    }
}