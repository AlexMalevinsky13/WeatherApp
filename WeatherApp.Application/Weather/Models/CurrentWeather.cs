namespace WeatherApp.Application.Weather.Models;

public class CurrentWeather
{
    public decimal TemperatureC { get; init; }

    public decimal FeelsLikeC { get; init; }

    public int Humidity { get; init; }

    public decimal PressureMb { get; init; }

    public decimal WindKph { get; init; }

    public string WindDirection { get; init; } = string.Empty;

    public string Condition { get; init; } = string.Empty;

    public string IconUrl { get; init; } = string.Empty;
}
