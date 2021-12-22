namespace TrainingBlazorApp.Server.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TrainingBlazorApp.Shared.Requests.Queries;
    using TrainingBlazorApp.Shared.Responses.Queries;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetWeatherForecast")]
        public async Task<GetWeatherForecastResponse> GetWeatherForecast(int maximum)
        {
            return await _mediator.Send(new GetWeatherForecastRequest
            {
                Maximum = maximum
            });
        }
    }
}
