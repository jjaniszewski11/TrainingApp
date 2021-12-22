namespace TrainingBlazorApp.UnitTests.Mappings
{
    using TrainingBlazorApp.Core.Entities;
    using TrainingBlazorApp.Shared.Dtos;
    using TrainingBlazorApp.UnitTests.Configuration;
    using Xunit;

    public class UnitMappingTest : TestBase
    {
        [Fact]
        public void WhenUnitEntityIsWellSet_UnitIsWellMapped()
        {
            // arrange
            AutoMapperInit();

            var unit = new Unit
            {
                Id = 3,
                Shortcut = "szt",
                Name = "sztuka",
                PrimaryUnit = "szt",
                PrimaryUnitConverter = 1,
                CommaOffset = 0
            };

            // act
            var unitMap = _mapper.Map<UnitDto>(unit);

            // assert
            Assert.NotNull(unitMap);
            Assert.Equal(unit.Id, unitMap.Id);
            Assert.Equal(unit.Shortcut, unitMap.Shortcut);
        }
    }
}
