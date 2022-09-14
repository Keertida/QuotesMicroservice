using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesMicroservice.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuotesMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinBusinessValue = table.Column<int>(type: "int", nullable: false),
                    MaxBusinessValue = table.Column<int>(type: "int", nullable: false),
                    MinPropertyValue = table.Column<int>(type: "int", nullable: false),
                    MaxPropertyValue = table.Column<int>(type: "int", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotesMasters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuotesMasters");
        }
    }
}
