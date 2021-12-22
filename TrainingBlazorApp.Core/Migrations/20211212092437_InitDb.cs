using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingBlazorApp.Core.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shortcut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryUnitConverter = table.Column<double>(type: "float", nullable: false),
                    CommaOffset = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "CommaOffset", "Name", "PrimaryUnit", "PrimaryUnitConverter", "Shortcut" },
                values: new object[,]
                {
                    { 1L, 0, "metr", "m", 1.0, "m" },
                    { 2L, 2, "centymetr", "cm", 0.01, "cm" },
                    { 3L, 0, "sztuka", "szt", 1.0, "szt" },
                    { 4L, 3, "milimetr", "m", 0.001, "mm" },
                    { 5L, 0, "metr kwadratowy", "m2", 1.0, "m2" },
                    { 6L, 4, "centymetr kwadratowy", "cm2", 0.0001, "cm2" },
                    { 7L, 0, "kilogram", "kg", 1.0, "kg" },
                    { 8L, 3, "gram", "g", 0.001, "g" },
                    { 9L, 6, "milimetr kwadratowy", "m2", 9.9999999999999995E-07, "mm2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
