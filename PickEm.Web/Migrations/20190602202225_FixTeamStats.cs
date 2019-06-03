using Microsoft.EntityFrameworkCore.Migrations;

namespace PickEm.Web.Migrations
{
    public partial class FixTeamStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AvgAst",
                table: "TeamModel",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgAst",
                table: "TeamModel");
        }
    }
}
