namespace TrainingBlazorApp.Core.QueryHandlers
{
    using MediatR;
    using System;
    using System.Linq;
    using TrainingBlazorApp.Shared;
    using TrainingBlazorApp.Shared.Requests.Queries;
    using TrainingBlazorApp.Shared.Responses.Queries;

    public class GetWeatherForecastHandler : RequestHandler<GetWeatherForecastRequest, GetWeatherForecastResponse>
    {
        private readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        protected override GetWeatherForecastResponse Handle(GetWeatherForecastRequest request)
        {
            var rng = new Random();
            var weather = Enumerable.Range(1, request.Maximum).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return new GetWeatherForecastResponse
            {
                WeatherForecasts = weather
            };
        }
    }
}
