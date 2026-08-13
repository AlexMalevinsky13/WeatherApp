using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.WeatherApi.Models;

public class WeatherApiResponse
{
    [JsonPropertyName("location")]
    public WeatherApiLocation Location { get; init; } = new();

    [JsonPropertyName("current")]
    public WeatherApiCurrent Current { get; init; } = new();

    [JsonPropertyName("forecast")]
    public WeatherApiForecast Forecast { get; init; } = new();
}
