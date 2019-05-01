using Microsoft.EntityFrameworkCore.Migrations;

namespace IrlFF.Data.Migrations
{
    public partial class WeeklyPointsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeekPoints",
                table: "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeekPoints",
                table: "Player",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalPoints",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalPoints",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalPoints",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalPoints",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeekPoints",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "WeekPoints",
                table: "Player");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalPoints",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalPoints",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalPoints",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalPoints",
                value: 1);
        }
    }
}
