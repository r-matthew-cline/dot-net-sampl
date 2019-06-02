using Microsoft.EntityFrameworkCore.Migrations;

namespace PickEm.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BracketModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CorrectPicks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BracketModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamModel",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    table.PrimaryKey("PK_TeamModel", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "GameModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HomeTeamId = table.Column<int>(nullable: true),
                    AwayTeamId = table.Column<int>(nullable: true),
                    HomeScore = table.Column<int>(nullable: true),
                    AwayScore = table.Column<int>(nullable: true),
                    Prediction = table.Column<bool>(nullable: true),
                    BracketModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameModel_TeamModel_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "TeamModel",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameModel_BracketModel_BracketModelId",
                        column: x => x.BracketModelId,
                        principalTable: "BracketModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameModel_TeamModel_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "TeamModel",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameModel_AwayTeamId",
                table: "GameModel",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GameModel_BracketModelId",
                table: "GameModel",
                column: "BracketModelId");

            migrationBuilder.CreateIndex(
                name: "IX_GameModel_HomeTeamId",
                table: "GameModel",
                column: "HomeTeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameModel");

            migrationBuilder.DropTable(
                name: "TeamModel");

            migrationBuilder.DropTable(
                name: "BracketModel");
        }
    }
}
