using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.WeatherApi.Models;

public class WeatherApiCurrent
{
    [JsonPropertyName("temp_c")]
    public decimal TemperatureC { get; init; }

    [JsonPropertyName("feelslike_c")]
    public decimal FeelsLikeC { get; init; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; init; }

    [JsonPropertyName("pressure_mb")]
    public decimal PressureMb { get; init; }

    [JsonPropertyName("wind_kph")]
    public decimal WindKph { get; init; }

    [JsonPropertyName("wind_dir")]
    public string WindDirection { get; init; } = string.Empty;

    [JsonPropertyName("condition")]
    public WeatherApiCondition Condition { get; init; } = new();
}
