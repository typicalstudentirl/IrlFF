using Microsoft.EntityFrameworkCore.Migrations;

namespace IrlFF.Data.Migrations
{
    public partial class AddSystemAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ForeName", "Password", "Role", "SurName", "TeamId", "Token", "UserName" },
                values: new object[] { -1, "System", "LOISystemAdmin", 0, "Administrator", null, null, "administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
