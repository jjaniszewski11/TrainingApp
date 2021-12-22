namespace TrainingBlazorApp.IntegrationTests.Configuration
{
    using Microsoft.AspNetCore.TestHost;
    using Microsoft.Extensions.Hosting;
    using Refit;
    using System.Net.Http;
    using System.Threading.Tasks;
    using TrainingBlazorApp.Shared.Infrastructure;
    using Xunit;

    public class ControllerTestBase : IAsyncLifetime
    {
        private IHost _host;
        protected HttpClient HttpClient { get; set; }
        protected IApiClient ApiClient { get; set; }

        public async Task InitializeAsync()
        {
            _host = await TestHttpClientFactory.SetupApi();
            HttpClient = _host.GetTestClient();

            ApiClient = RestService.For<IApiClient>(HttpClient, new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            });
        }

        public Task DisposeAsync()
        {
            HttpClient?.Dispose();
            HttpClient = null;

            _host?.Dispose();
            _host = null;

            return Task.CompletedTask;
        }
    }
}
