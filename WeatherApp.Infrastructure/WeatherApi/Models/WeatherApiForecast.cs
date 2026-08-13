using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.WeatherApi.Models;

public class WeatherApiForecast
{
    [JsonPropertyName("forecastday")]
    public IReadOnlyCollection<WeatherApiForecastDay> Days { get; init; } = [];
}
