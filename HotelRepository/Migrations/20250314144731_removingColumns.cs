using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class removingColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "ConcurrencyStamp",
                value: "05f574d4-de44-41f5-a785-0f98cc8ff017");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "ConcurrencyStamp",
                value: "7ed4fb5a-ad9a-4fa9-afe4-fe397e399489");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "ConcurrencyStamp",
                value: "2b79c4f5-5525-4fa5-82a7-97754479bfd7");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "ConcurrencyStamp",
                value: "a364d075-4ac1-48c9-8ef8-b44f0bfb6410");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "ConcurrencyStamp",
                value: "da47227a-908f-468a-b34e-4722994842a1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Customers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "LockoutEnd", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled" },
                values: new object[] { 0, "4f6a5743-b1f8-4ba8-8a4f-de9b605fd408", false, null, "123456789", false, false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "LockoutEnd", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled" },
                values: new object[] { 0, "b5b94fb6-55b8-4e49-857a-c73112f3198d", false, null, "123456789", false, false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "LockoutEnd", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled" },
                values: new object[] { 0, "176d0e8a-449a-4560-b687-a4f8bb9b1b78", false, null, "123456789", false, false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "LockoutEnd", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled" },
                values: new object[] { 0, "3a87f2cb-07cf-4b6c-a030-3330e99cb95b", false, null, "123456789", false, false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "LockoutEnd", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled" },
                values: new object[] { 0, "ab2f15dc-21ab-4597-8323-b2fa9cc61a58", false, null, "123456789", false, false });
        }
    }
}
