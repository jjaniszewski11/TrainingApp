namespace TrainingBlazorApp.Shared.Requests.Queries
{
    using TrainingBlazorApp.Shared.Infrastructure;
    using TrainingBlazorApp.Shared.Responses.Queries;

    public class GetWeatherForecastRequest : IQuery<GetWeatherForecastResponse>
    {
        public int Maximum { get; set; }
    }
}
