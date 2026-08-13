namespace WeatherApp.Infrastructure.WeatherApi
{
    public class WeatherApiOptions
    {
        public const string SectionName = "WeatherApi";

        public string BaseUrl { get; init; } = string.Empty;

        public string ApiKey { get; init; } = string.Empty;

        public decimal Latitude { get; init; }

        public decimal Longitude { get; init; }
    }
}
