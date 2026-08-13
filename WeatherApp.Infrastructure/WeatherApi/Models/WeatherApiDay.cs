using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.WeatherApi.Models;

public class WeatherApiDay
{
    [JsonPropertyName("maxtemp_c")]
    public decimal MaxTemperatureC { get; init; }

    [JsonPropertyName("mintemp_c")]
    public decimal MinTemperatureC { get; init; }

    [JsonPropertyName("condition")]
    public WeatherApiCondition Condition { get; init; } = new();
}
