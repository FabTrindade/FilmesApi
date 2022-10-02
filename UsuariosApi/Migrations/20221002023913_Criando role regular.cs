using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "e6629998-7b5e-4fab-b980-a9590c403f0d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "6dc3a002-a603-4f7f-8562-f67d3c72f888", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64da2edb-687a-424f-8cb2-a12b4d927aa0", "AQAAAAEAACcQAAAAEErcdo9IFJloMtFPjpBuES7e0B1cvwhl/btXOiSvbDOkEVBEFkLVDTBOKrkIoiJlxA==", "b8f022c0-e41d-409e-85bd-f8f751857fbc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "4e0ac8fe-52da-49ff-979d-8ccbedede830");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dc79b82-8593-4258-83e2-edb7532ec1ee", "AQAAAAEAACcQAAAAEOrjZeLvpooIpCsDvWPi1QrEyOUzAVooNrzgamnTlRruKgNbF9Uzav+Q0sPQ4O8FNw==", "0ed6e9d7-6f6a-45f4-b561-3f616eef4479" });
        }
    }
}
