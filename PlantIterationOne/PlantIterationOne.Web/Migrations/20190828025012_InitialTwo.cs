using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantIterationOne.Web.Migrations
{
    public partial class InitialTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BotanicalName",
                table: "Natives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "Natives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoilTexture",
                table: "Natives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Natives",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Invasives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    Habitat = table.Column<string>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true),
                    Spreads = table.Column<string>(nullable: true),
                    Impacts = table.Column<string>(nullable: true),
                    WeedControl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invasives", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invasives");

            migrationBuilder.DropColumn(
                name: "BotanicalName",
                table: "Natives");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "Natives");

            migrationBuilder.DropColumn(
                name: "SoilTexture",
                table: "Natives");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Natives");
        }
    }
}
