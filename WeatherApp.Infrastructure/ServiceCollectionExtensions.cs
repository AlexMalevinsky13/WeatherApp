using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Application.Abstractions;
using WeatherApp.Infrastructure.Providers;
using WeatherApp.Infrastructure.WeatherApi;

namespace WeatherApp.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<WeatherApiOptions>(configuration.GetSection(WeatherApiOptions.SectionName));

        services.AddHttpClient<IWeatherProvider, WeatherApiProvider>(client =>
        {
            var baseUrl = configuration[$"{WeatherApiOptions.SectionName}:BaseUrl"];
            client.BaseAddress = new Uri(baseUrl!);
        });

        return services;
    }
}
