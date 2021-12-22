namespace TrainingBlazorApp.Server.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TrainingBlazorApp.Shared.Requests.Queries;
    using TrainingBlazorApp.Shared.Responses.Queries;

    [Route("[controller]")]
    [ApiController]
    public class ReadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetUnits")]
        public async Task<GetUnitsResponse> GetUnits()
        {
            return await _mediator.Send(new GetUnitsRequest { });
        }
    }
}
