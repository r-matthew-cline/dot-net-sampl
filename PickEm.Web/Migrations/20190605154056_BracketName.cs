using Microsoft.EntityFrameworkCore.Migrations;

namespace PickEm.Web.Migrations
{
    public partial class BracketName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BracketModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BracketModel");
        }
    }
}
