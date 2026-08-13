using WeatherApp.Application.Weather.Models;

namespace WeatherApp.Application.Abstractions;

public interface IWeatherProvider
{
    Task<WeatherForecast> GetWeatherAsync(CancellationToken cancellationToken = default);
}
