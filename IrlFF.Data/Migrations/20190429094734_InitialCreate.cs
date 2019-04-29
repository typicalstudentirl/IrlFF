using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrlFF.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fixture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    ForeName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Forename = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    TotalPoints = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    ClubId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeClub = table.Column<string>(nullable: true),
                    AwayClub = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    FixtureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Fixture_FixtureId",
                        column: x => x.FixtureId,
                        principalTable: "Fixture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Forename = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    TeamName = table.Column<string>(nullable: true),
                    TotalPoints = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamPlayer",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamPlayer", x => new { x.TeamId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_TeamPlayer_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamPlayer_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "Id", "ClubName" },
                values: new object[,]
                {
                    { 1, "Bohemians FC" },
                    { 2, "Cork City" },
                    { 3, "Derry City" },
                    { 4, "Dundalk FC" },
                    { 5, "Finn Harps" },
                    { 6, "Shamrock Rovers" },
                    { 7, "Sligo Rovers" },
                    { 8, "St. Pats" },
                    { 9, "U.C.D" },
                    { 10, "Waterford" }
                });

            migrationBuilder.InsertData(
                table: "Fixture",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayClub", "Date", "FixtureId", "HomeClub", "Location" },
                values: new object[,]
                {
                    { 10, "St. Pats", new DateTime(2019, 2, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sligo Rovers", "The Showgrounds" },
                    { 2, "Cork City", new DateTime(2019, 2, 12, 15, 45, 0, 0, DateTimeKind.Unspecified), 1, "St. Pats", "Richmond Park" },
                    { 3, "Sligo Rovers", new DateTime(2019, 2, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 1, "Dundalk", "Oriel Park" },
                    { 4, "U.C.D", new DateTime(2019, 2, 15, 20, 19, 45, 0, DateTimeKind.Unspecified), 1, "Derry City", "The Brandywell Stadium" },
                    { 1, "Shamrock Rovers", new DateTime(2019, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, "Waterford", "Waterford RSC" },
                    { 6, "Waterford", new DateTime(2019, 2, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cork City", "Turner's Cross" },
                    { 7, "Derry City", new DateTime(2019, 2, 22, 19, 45, 0, 0, DateTimeKind.Unspecified), 2, "Shamrock Rovers", "Tallaght Stadium" },
                    { 8, "Dundalk", new DateTime(2019, 2, 22, 19, 45, 0, 0, DateTimeKind.Unspecified), 2, "Finn Harps", "Finn Park" },
                    { 5, "Finn Harps", new DateTime(2019, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bohemians", "Dalymount Park" },
                    { 9, "Bohemians", new DateTime(2019, 2, 22, 20, 19, 45, 0, DateTimeKind.Unspecified), 2, "U.C.D", "U.C.D Bowl" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "ClubId", "Forename", "Position", "Surname", "TotalPoints" },
                values: new object[,]
                {
                    { 19, 3, "Shane", 3, "McNamee", 0 },
                    { 26, 3, "Eoghan", 4, "Stokes", 0 },
                    { 25, 3, "Junior", 4, "Ogedi-Uzokwe", 0 },
                    { 24, 3, "Michael", 4, "McCrudden", 0 },
                    { 23, 3, "David", 4, "Parkhouse", 0 },
                    { 22, 3, "Ronan", 3, "McKinley", 0 },
                    { 21, 3, "Barry", 3, "McNamee", 0 },
                    { 20, 3, "Gianni", 3, "Seraf", 0 },
                    { 18, 3, "Evan", 3, "Tweed", 0 },
                    { 16, 3, "Gerardo", 3, "Bruna", 0 },
                    { 2, 3, "Nathan", 1, "Gartside", 2 },
                    { 3, 3, "Rhys", 2, "McDermott", 0 },
                    { 4, 3, "Connor", 2, "McDermott", 4 },
                    { 5, 3, "Ciaran", 2, "Coll", 1 },
                    { 6, 3, "Eoin", 2, "Toal", 0 },
                    { 7, 3, "Patrick", 2, "McClean", 0 },
                    { 17, 3, "Adrian", 3, "Delap", 0 },
                    { 8, 3, "Darren", 2, "Cole", 0 },
                    { 10, 3, "Ally", 2, "Gilchrist", 0 },
                    { 11, 3, "Brendan", 3, "Barr", 0 },
                    { 12, 3, "Conor", 3, "Gormley", 0 },
                    { 13, 3, "Ciaron", 3, "Harkin", 0 },
                    { 14, 3, "Greg", 3, "Sloggett", 0 },
                    { 15, 3, "Jamie", 3, "McDonagh", 0 },
                    { 9, 3, "Josh", 2, "Kerr", 0 },
                    { 1, 3, "Peter", 1, "Cherrie", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_FixtureId",
                table: "Matches",
                column: "FixtureId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_ClubId",
                table: "Player",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_UserId",
                table: "Team",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayer_PlayerId",
                table: "TeamPlayer",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "TeamPlayer");

            migrationBuilder.DropTable(
                name: "Fixture");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
