using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class seedingIdentity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "IdentityNumber",
                value: "12345678999");

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "IdentityNumber",
                value: "92345678999");

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "IdentityNumber",
                value: "99945678903");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "IdentityNumber",
                value: "12345678901");

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "IdentityNumber",
                value: "12345678902");

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "IdentityNumber",
                value: "12345678903");
        }
    }
}
