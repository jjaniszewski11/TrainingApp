namespace TrainingBlazorApp.IntegrationTests.Configuration
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.TestHost;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System.Linq;
    using System.Threading.Tasks;
    using TrainingBlazorApp.Core;
    using TrainingBlazorApp.IntegrationTests.Configuration.Settings;
    using TrainingBlazorApp.Server.Test;

    internal class TestHttpClientFactory
    {
        internal static async Task<IHost> SetupApi()
        {
            var hostBuilder = new HostBuilder().ConfigureWebHost(o =>
            {
                o.UseTestServer()
                    .UseEnvironment(Environments.Development)
                    .UseStartup<TestStartup>();

                o.ConfigureTestServices(s =>
                {
                    var descriptor = s.SingleOrDefault(
                        d => d.ServiceType == typeof(DbContextOptions<DataContext>));

                    s.Remove(descriptor);

                    s.AddEntityFrameworkInMemoryDatabase();
                    s.AddDbContext<DataContext>(o =>
                    {
                        o.UseInMemoryDatabase("InMemoryDatabase");
                    });

                    s.AddMvc(o =>
                    {
                        o.Filters.Add(new UserFilter());
                    });

                    var provider = s.BuildServiceProvider();
                    using var scope = provider.CreateScope();

                    var scopedServices = scope.ServiceProvider;
                    var appDb = scopedServices.GetRequiredService<DataContext>();

                    appDb.Database.EnsureCreated();
                });
            });

            return await hostBuilder.StartAsync();
        }
    }
}