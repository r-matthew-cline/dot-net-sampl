using Microsoft.EntityFrameworkCore.Migrations;

namespace PickEm.Web.Migrations
{
    public partial class BracketPositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BracketPosition",
                table: "GameModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BracketPosition",
                table: "GameModel");
        }
    }
}
