namespace TrainingBlazorApp.Core.Mappings.MappingProfile
{
    using AutoMapper;
    using TrainingBlazorApp.Core.Entities;
    using TrainingBlazorApp.Shared.Dtos;

    public class UnitMappingProfile : Profile
    {
        public UnitMappingProfile()
        {
            CreateMap<Unit, UnitDto>().ReverseMap();
        }
    }
}
