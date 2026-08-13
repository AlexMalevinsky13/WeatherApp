using MediatR;
using WeatherApp.Application.Abstractions;
using WeatherApp.Application.Weather.Models;

namespace WeatherApp.Application.Weather.Queries;

public sealed class GetWeatherQueryHandler(IWeatherProvider weatherProvider) 
    : IRequestHandler<GetWeatherQuery, WeatherForecast>
{
    public Task<WeatherForecast> Handle(GetWeatherQuery request, CancellationToken cancellationToken) =>
        weatherProvider.GetWeatherAsync(cancellationToken);
}
