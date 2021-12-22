namespace TrainingBlazorApp.UnitTests.Configuration
{
    using AutoMapper;
    using TrainingBlazorApp.Core.Mappings.MappingProfile;

    public class TestBase
    {
        protected IMapper _mapper;

        public void AutoMapperInit()
        {
            if (_mapper is null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new UnitMappingProfile());
                });
                var mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }
    }
}
