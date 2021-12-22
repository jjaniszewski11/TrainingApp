namespace TrainingBlazorApp.IntegrationTests.Configuration.Settings
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class UserFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.HttpContext.User = new ClaimsPrincipal();

            await next();
        }
    }
}
