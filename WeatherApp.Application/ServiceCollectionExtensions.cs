using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Application.Weather.Queries;

namespace WeatherApp.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config =>
            config.RegisterServicesFromAssemblyContaining<GetWeatherQueryHandler>());

        return services;
    }
}