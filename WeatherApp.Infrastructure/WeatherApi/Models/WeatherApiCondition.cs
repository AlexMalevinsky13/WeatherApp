using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.WeatherApi.Models;

public class WeatherApiCondition
{
    [JsonPropertyName("text")]
    public string Text { get; init; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; init; } = string.Empty;
}
