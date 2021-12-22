namespace TrainingBlazorApp.Core.Mappings
{
    using AutoMapper;
    using TrainingBlazorApp.Core.Mappings.MappingProfile;

    public class MapperManager
    {
        public static IMapper GetMapper => new MapperConfiguration(mc =>
        {
            mc.AddProfile(new UnitMappingProfile());
        })
        .CreateMapper();
    }
}
