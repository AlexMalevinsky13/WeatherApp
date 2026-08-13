using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.WeatherApi.Models;

public class WeatherApiForecastDay
{
    [JsonPropertyName("date")]
    public string Date { get; init; } = string.Empty;

    [JsonPropertyName("day")]
    public WeatherApiDay Day { get; init; } = new();

    [JsonPropertyName("hour")]
    public IReadOnlyCollection<WeatherApiHour> Hours { get; init; } = [];
}
