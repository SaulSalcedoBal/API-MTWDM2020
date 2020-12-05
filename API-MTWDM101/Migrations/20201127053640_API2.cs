using Microsoft.EntityFrameworkCore.Migrations;

namespace API_MTWDM101.Migrations
{
    public partial class API2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LoginModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "1234", "SaulSalcedo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LoginModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "test", "tests" });
        }
    }
}
