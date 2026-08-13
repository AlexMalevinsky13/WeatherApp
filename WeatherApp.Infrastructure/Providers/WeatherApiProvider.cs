using Microsoft.Extensions.Options;
using System.Globalization;
using System.Net.Http.Json;
using WeatherApp.Application.Abstractions;
using WeatherApp.Application.Weather.Models;
using WeatherApp.Infrastructure.WeatherApi;
using WeatherApp.Infrastructure.WeatherApi.Models;

namespace WeatherApp.Infrastructure.Providers;

internal class WeatherApiProvider(HttpClient httpClient,
                                  IOptions<WeatherApiOptions> options) : IWeatherProvider
{
    private readonly WeatherApiOptions _options = options.Value;

    public async Task<WeatherForecast> GetWeatherAsync(CancellationToken cancellationToken = default)
    {
        var latitude = _options.Latitude.ToString(CultureInfo.InvariantCulture);
        var longitude = _options.Longitude.ToString(CultureInfo.InvariantCulture);

        var url = $"forecast.json?key={_options.ApiKey}&q={latitude},{longitude}&days=3&lang=ru";

        var response = await httpClient.GetFromJsonAsync<WeatherApiResponse>(url, cancellationToken)
            ?? throw new InvalidOperationException("Weather API returned an empty response.");

        return Map(response);
    }

    private static WeatherForecast Map(WeatherApiResponse response)
    {
        var localTime = DateTime.Parse(response.Location.LocalTime, CultureInfo.InvariantCulture);

        var days = response.Forecast.Days.ToArray();

        var todayHours = days.Length > 0
            ? days[0].Hours
                .Where(x => DateTime.Parse(x.Time, CultureInfo.InvariantCulture) > localTime)
                .Select(MapHour).ToArray() : [];

        var tomorrowHours = days.Length > 1 ? days[1].Hours.Select(MapHour).ToArray() : [];

        var dailyForecast = days
            .Select(x => new DailyWeather
            {
                Date = DateOnly.Parse(x.Date, CultureInfo.InvariantCulture),
                MinTemperatureC = x.Day.MinTemperatureC,
                MaxTemperatureC = x.Day.MaxTemperatureC,
                Condition = x.Day.Condition.Text,
                IconUrl = NormalizeIconUrl(x.Day.Condition.Icon)
            }).ToArray();

        return new WeatherForecast
        {
            LocationName = response.Location.Name,
            Current = new CurrentWeather
            {
                TemperatureC = response.Current.TemperatureC,
                FeelsLikeC = response.Current.FeelsLikeC,
                Humidity = response.Current.Humidity,
                PressureMb = response.Current.PressureMb,
                WindKph = response.Current.WindKph,
                WindDirection = response.Current.WindDirection,
                Condition = response.Current.Condition.Text,
                IconUrl = NormalizeIconUrl(response.Current.Condition.Icon)
            },
            TodayHours = todayHours,
            TomorrowHours = tomorrowHours,
            DailyForecast = dailyForecast
        };
    }

    private static HourlyWeather MapHour(WeatherApiHour hour) =>
        new()
        {
            Time = DateTime.Parse(hour.Time, CultureInfo.InvariantCulture),
            TemperatureC = hour.TemperatureC,
            Condition = hour.Condition.Text,
            IconUrl = NormalizeIconUrl(hour.Condition.Icon)
        };

    private static string NormalizeIconUrl(string icon)
    {
        if (string.IsNullOrWhiteSpace(icon))
            return string.Empty;

        return icon.StartsWith("//")
            ? $"https:{icon}"
            : icon;
    }
}
