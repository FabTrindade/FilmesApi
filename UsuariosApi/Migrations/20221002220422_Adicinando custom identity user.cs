using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicinandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "73b0c61c-13f8-45c1-802b-f3def77f0842");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "1ed2194e-d4d8-4dc1-9dac-2cc69fa51899");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b539c09-7a8f-4a0e-a1e4-61f573e0584d", "AQAAAAEAACcQAAAAEC748lBlf2+diJzZAiJUtBcGaWAOwoBq0RuUjpgc9t59c1XLfxk14ZwzdYQF1rF/JQ==", "2ddc415a-222e-4a5b-a55f-a7953dceb496" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "6dc3a002-a603-4f7f-8562-f67d3c72f888");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "e6629998-7b5e-4fab-b980-a9590c403f0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64da2edb-687a-424f-8cb2-a12b4d927aa0", "AQAAAAEAACcQAAAAEErcdo9IFJloMtFPjpBuES7e0B1cvwhl/btXOiSvbDOkEVBEFkLVDTBOKrkIoiJlxA==", "b8f022c0-e41d-409e-85bd-f8f751857fbc" });
        }
    }
}
