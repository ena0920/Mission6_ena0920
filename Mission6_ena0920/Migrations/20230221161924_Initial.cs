using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_ena0920.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Fantasy", "Jared Bush", false, "Emma Antonucci", null, "PG", "Encanto", (ushort)2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Crime Comedy", "Ethan Coen", false, "Camilla Antonucci", null, "PG-13", "Raising Arizona", (ushort)1987 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Biographical", "Theodore Melfi", false, "Kayla Antonucci", null, "PG-13", "Hidden Figures", (ushort)2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
