namespace WeatherApp.Application.Weather.Models
{
    public class WeatherForecast
    {
        public string LocationName { get; init; } = string.Empty;

        public CurrentWeather Current { get; init; } = new();

        public IReadOnlyCollection<HourlyWeather> TodayHours { get; init; } = [];

        public IReadOnlyCollection<HourlyWeather> TomorrowHours { get; init; } = [];

        public IReadOnlyCollection<DailyWeather> DailyForecast { get; init; } = [];
    }
}
