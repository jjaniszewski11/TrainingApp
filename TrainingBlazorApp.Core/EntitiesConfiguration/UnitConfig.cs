namespace TrainingBlazorApp.Core.EntitiesConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TrainingBlazorApp.Core.Entities;
    using TrainingBlazorApp.Core.EntitiesConfiguration.Data;

    public class UnitConfig : InitialData<Unit>, IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();

            // ---

            PrepareInitialData(builder);
        }

        public override void PrepareInitialData(EntityTypeBuilder<Unit> builder)
        {
            builder.HasData
            (
                new Unit
                {
                    Id = 1,
                    Shortcut = "m",
                    Name = "metr",
                    PrimaryUnit = "m",
                    PrimaryUnitConverter = 1,
                    CommaOffset = 0
                },
                new Unit
                {
                    Id = 2,
                    Shortcut = "cm",
                    Name = "centymetr",
                    PrimaryUnit = "cm",
                    PrimaryUnitConverter = 0.01,
                    CommaOffset = 2
                },
                new Unit
                {
                    Id = 3,
                    Shortcut = "szt",
                    Name = "sztuka",
                    PrimaryUnit = "szt",
                    PrimaryUnitConverter = 1,
                    CommaOffset = 0
                },
                new Unit
                {
                    Id = 4,
                    Shortcut = "mm",
                    Name = "milimetr",
                    PrimaryUnit = "m",
                    PrimaryUnitConverter = 0.001,
                    CommaOffset = 3
                },
                new Unit
                {
                    Id = 5,
                    Shortcut = "m2",
                    Name = "metr kwadratowy",
                    PrimaryUnit = "m2",
                    PrimaryUnitConverter = 1,
                    CommaOffset = 0
                },
                new Unit
                {
                    Id = 6,
                    Shortcut = "cm2",
                    Name = "centymetr kwadratowy",
                    PrimaryUnit = "cm2",
                    PrimaryUnitConverter = 0.0001,
                    CommaOffset = 4
                },
                new Unit
                {
                    Id = 7,
                    Shortcut = "kg",
                    Name = "kilogram",
                    PrimaryUnit = "kg",
                    PrimaryUnitConverter = 1,
                    CommaOffset = 0
                },
                new Unit
                {
                    Id = 8,
                    Shortcut = "g",
                    Name = "gram",
                    PrimaryUnit = "g",
                    PrimaryUnitConverter = 0.001,
                    CommaOffset = 3
                },
                new Unit
                {
                    Id = 9,
                    Shortcut = "mm2",
                    Name = "milimetr kwadratowy",
                    PrimaryUnit = "m2",
                    PrimaryUnitConverter = 0.000001,
                    CommaOffset = 6
                }
            );
        }
    }
}
