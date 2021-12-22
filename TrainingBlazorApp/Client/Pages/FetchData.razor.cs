namespace TrainingBlazorApp.Client.Pages
{
    using Microsoft.AspNetCore.Components;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TrainingBlazorApp.Shared;
    using TrainingBlazorApp.Shared.Infrastructure;
    using TrainingBlazorApp.Shared.Requests.Queries;

    [Route("/fetchdata")]
    public partial class FetchData
    {
        [Inject] private IApiClient ApiClient { get; set; }

        private IEnumerable<WeatherForecast> forecasts;

        protected override async Task OnInitializedAsync()
        {
            var response = await ApiClient.GetWeatherForecast(new GetWeatherForecastRequest
            {
                Maximum = 20
            });

            forecasts = response.WeatherForecasts;
        }
    }
}
