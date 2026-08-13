namespace WeatherApp.Application.Weather.Models;

public sealed class HourlyWeather
{
    public DateTime Time { get; init; }

    public decimal TemperatureC { get; init; }

    public string Condition { get; init; } = string.Empty;

    public string IconUrl { get; init; } = string.Empty;
}
