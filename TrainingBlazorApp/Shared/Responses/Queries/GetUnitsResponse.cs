namespace TrainingBlazorApp.Shared.Responses.Queries
{
    using System.Collections.Generic;
    using TrainingBlazorApp.Shared.Dtos;

    public class GetUnitsResponse
    {
        public IEnumerable<UnitDto> Units { get; set; }
    }
}
