namespace TrainingBlazorApp.IntegrationTests.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using TrainingBlazorApp.IntegrationTests.Configuration;
    using TrainingBlazorApp.Shared.Requests.Queries;
    using Xunit;

    public class ReadController : ControllerTestBase
    {
        [Fact]
        public async Task can_retrieve_all_units()
        {
            // arrange

            // act
            var response = await ApiClient.GetUnits(new GetUnitsRequest());

            Assert.NotNull(response);
            Assert.Equal(9, response.Units.Count());
        }
    }
}
