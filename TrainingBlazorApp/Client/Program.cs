namespace TrainingBlazorApp.Client
{
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Refit;
    using System;
    using System.Threading.Tasks;
    using TrainingBlazorApp.Shared.Infrastructure;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            ConfigureRefit(builder);
            ConfigureLocalization(builder);

            await builder.Build().RunAsync();
        }

        private static void ConfigureRefit(WebAssemblyHostBuilder builder)
        {
            var settings = new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            };

            builder.Services.AddRefitClient<IApiClient>(settings)
                .ConfigureHttpClient(c => { c.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); });
        }

        private static void ConfigureLocalization(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddLocalization();
        }
    }
}
