namespace TrainingBlazorApp.Core.QueryHandlers
{
    using AutoMapper;
    using MediatR;
    using System.Collections.Generic;
    using System.Linq;
    using TrainingBlazorApp.Shared.Dtos;
    using TrainingBlazorApp.Shared.Requests.Queries;
    using TrainingBlazorApp.Shared.Responses.Queries;

    public class GetUnitsHandler : RequestHandler<GetUnitsRequest, GetUnitsResponse>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetUnitsHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        protected override GetUnitsResponse Handle(GetUnitsRequest request)
        {
            var units = _context.Units.ToList();
            var unitsDto = _mapper.Map<IEnumerable<UnitDto>>(units);

            return new GetUnitsResponse
            {
                Units = unitsDto
            };
        }
    }
}
