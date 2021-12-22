namespace TrainingBlazorApp.Shared.Responses.Queries
{
    using System.Collections.Generic;

    public class GetWeatherForecastResponse
    {
        public IEnumerable<WeatherForecast> WeatherForecasts { get; set; }
    }
}
