namespace TrainingBlazorApp.Shared.Infrastructure
{
    using Refit;
    using System.Threading.Tasks;
    using TrainingBlazorApp.Shared.Requests.Queries;
    using TrainingBlazorApp.Shared.Responses.Queries;

    public interface IApiClient
    {
        [Get("/WeatherForecast/GetWeatherForecast")]
        Task<GetWeatherForecastResponse> GetWeatherForecast(GetWeatherForecastRequest request);

        [Get("/Read/GetUnits")]
        Task<GetUnitsResponse> GetUnits(GetUnitsRequest request);
    }
}
