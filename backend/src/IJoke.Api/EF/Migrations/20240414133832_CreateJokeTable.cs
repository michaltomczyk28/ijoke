using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IJoke.Api.EF.Migrations
{
    /// <inheritdoc />
    public partial class CreateJokeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joke",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    AuthorName = table.Column<string>(type: "text", nullable: false),
                    Votes = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joke", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Joke",
                columns: new[] { "Id", "AuthorName", "Content", "CreatedAt", "Votes" },
                values: new object[,]
                {
                    { new Guid("43629dc3-92ab-4e69-8f12-7e3d19e5614b"), "Frezja26 (dowcipy.jeja.pl)", "Dyrektor do swojego pracownika:\n- Z pana to byłby doskonały przestępca...\n- Dlaczego?\n- Bo nie zostawia pan żadnych śladów swojej działalności...", new DateTime(2024, 4, 14, 13, 38, 31, 956, DateTimeKind.Utc).AddTicks(7460), 0 },
                    { new Guid("6d1f687b-b883-47f3-8ec6-582700973c56"), "Polymorphism1 (dowcipy.jeja.pl)", "Rozmowa telefoniczna dwóch kolegów stolarzy:\n- Cześć, co robisz?\n- Krzesło dla teściowej.\n- A dużo Ci jeszcze zostało do zrobienia? Może na flaszkę wpadniesz?\n- Ok. Nie ma problemu. Podłączę tylko przewody i jestem...", new DateTime(2024, 4, 14, 13, 38, 31, 956, DateTimeKind.Utc).AddTicks(7470), 0 },
                    { new Guid("a59351ec-920a-4081-87a2-e1649d3acfde"), "Cziszczus (dowcipy.jeja.pl)", "- Jesteście matołami! 80% z was nie ma pojęcia o matematyce! - krzyczy nauczyciel.\n- No bez przesady! Tylu to nas nawet nie ma w klasie!", new DateTime(2024, 4, 14, 13, 38, 31, 956, DateTimeKind.Utc).AddTicks(7460), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joke");
        }
    }
}
