using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class changing_table_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerReservations_Users_CustomerId",
                table: "CustomerReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Users/Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_IdentityNumber",
                table: "Users/Customers",
                newName: "IX_Users/Customers_IdentityNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users/Customers",
                table: "Users/Customers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEF88O5Vs0c1xJzFsFc4gX6cDPhmtBrzl32WJihglTlz77tcKOcJYdytmXbW/5LITyw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM795J1yiVO+IoO0UwAM05gFU/1oMBoSyrGPBFskd0fMjKid4lxrwuUNxgEcNzlxig==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP7gKz/2CRg9rexA45YfM4DgP5riCqipQkRfniBAxdjjTtVbYBsv8hdCmN6ucvASAw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFz5pElG4qOJZi9QmwYUrDEm+WjUs1Qv/0gEzLM2N3NKLtNP6+UgdbkVP7qArpAmSQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIS/qI42E9zCEGjrubL/A036HhOnXU9oP67MyQH3L/uCnIRKYu1mauPN8HRB7rlqbw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOu7QcqFeNSM+QreNqpXEBE10QKe2Yy3TDdeTqCLX1ayVb6zF+Ca8rVUOHGnoTEJLw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIvvG2rEKJ7NDVy1Kso6SGqBwzaZsYTBQ191kWl3a/cwQKGrC40Yz/rvxGAd03r6wA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIKkyzwF0/8nxxeMRJxULHKarDjCduYKZZoJWNtMNA+mAQWnR8q1QwOqI+O9/6o0Ug==");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerReservations_Users/Customers_CustomerId",
                table: "CustomerReservations",
                column: "CustomerId",
                principalTable: "Users/Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users/Customers_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users/Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerReservations_Users/Customers_CustomerId",
                table: "CustomerReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users/Customers_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users/Customers",
                table: "Users/Customers");

            migrationBuilder.RenameTable(
                name: "Users/Customers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_Users/Customers_IdentityNumber",
                table: "Users",
                newName: "IX_Users_IdentityNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC1al0jrs3clEmKNngE75NwBNspg42emGQfbFSbE4cNAgzms76+0oOU9JKEmPEIoPw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM0HCM0U0kbca+9e/ruAvj+7d2gY7zNoZzqfO0PUJ8WxmFwHWomn2BJY+QsoLozLcw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8XfR72QE0kCMmTQQnUiYDAQc5oU+QsnK+5j3bKyqLadANRYoPwtxBMAXHnlfYmzA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGen5H9NA+FrYVQEnaJYUAj6Ca2xpPmQANjxamYN6WSU8dJdWDUHOXQOL6+74IiaGQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDXCi2LsGnFX3xV/B+33yhSmnMhFlR7IM73nydYbU4d4qzkXSMwIvdE3bhJF2cKkHA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBC62tZSozi3qyqHIGYrOMiyl5r3Zvt4ASe2sMoRq9hb/WpkTkis/jQ5dWBgc7IzdA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECCMYG6yUyo3DovGZAalsAyPqunf4USvnfmT63NfudQ2x8RXIi1PtC3KJqgDPjwvYQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM6Af3lcXWf3LGWXhb0GkpBTKVP/W+DLs9Xh4sIVtbscK5DUidKztdE0AJDiYLb6Pg==");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerReservations_Users_CustomerId",
                table: "CustomerReservations",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
