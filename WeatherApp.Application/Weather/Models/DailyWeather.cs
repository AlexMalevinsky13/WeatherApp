namespace WeatherApp.Application.Weather.Models;

public class DailyWeather
{
    public DateOnly Date { get; init; }

    public decimal MinTemperatureC { get; init; }

    public decimal MaxTemperatureC { get; init; }

    public string Condition { get; init; } = string.Empty;

    public string IconUrl { get; init; } = string.Empty;
}
