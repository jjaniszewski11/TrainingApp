namespace TrainingBlazorApp.IntegrationTests.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using TrainingBlazorApp.IntegrationTests.Configuration;
    using TrainingBlazorApp.Shared.Requests.Queries;
    using Xunit;

    public class WeatherForecastControllerTest : ControllerTestBase
    {
        [Fact]
        public async Task TestWeatherForecast()
        {
            var response = await ApiClient.GetWeatherForecast(new GetWeatherForecastRequest
            {
                Maximum = 20
            });

            Assert.NotNull(response);
            Assert.Equal(20, response.WeatherForecasts.Count());
        }
    }
}
