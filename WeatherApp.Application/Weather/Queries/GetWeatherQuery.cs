using MediatR;
using WeatherApp.Application.Weather.Models;

namespace WeatherApp.Application.Weather.Queries;

public class GetWeatherQuery : IRequest<WeatherForecast>;
