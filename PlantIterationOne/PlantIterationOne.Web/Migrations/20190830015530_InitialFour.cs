using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantIterationOne.Web.Migrations
{
    public partial class InitialFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Invasives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Invasives");
        }
    }
}
