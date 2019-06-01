using Microsoft.EntityFrameworkCore.Migrations;

namespace PickEm.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HomeTeamId = table.Column<int>(nullable: false),
                    AwayTeamId = table.Column<int>(nullable: false),
                    HomeScore = table.Column<int>(nullable: false),
                    AwayScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AvgScore = table.Column<decimal>(nullable: false),
                    AvgOppScore = table.Column<decimal>(nullable: false),
                    AvgOffReb = table.Column<decimal>(nullable: false),
                    AvgDefReb = table.Column<decimal>(nullable: false),
                    AvgStl = table.Column<decimal>(nullable: false),
                    AvgBlk = table.Column<decimal>(nullable: false),
                    Seed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
