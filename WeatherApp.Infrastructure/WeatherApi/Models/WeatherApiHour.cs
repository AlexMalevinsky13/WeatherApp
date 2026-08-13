using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.WeatherApi.Models;

public class WeatherApiHour
{
    [JsonPropertyName("time")]
    public string Time { get; init; } = string.Empty;

    [JsonPropertyName("temp_c")]
    public decimal TemperatureC { get; init; }

    [JsonPropertyName("condition")]
    public WeatherApiCondition Condition { get; init; } = new();
}
