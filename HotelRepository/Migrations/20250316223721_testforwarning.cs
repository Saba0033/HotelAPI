using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class testforwarning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELu72bol2ViYEl8n+JL5KXSjJTuRafVHJaB9dFEzjgnKD6jlxN2xbDLHy8kalrGn7w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECkP4ErIYBfUnERSS279+dJhWTxYQJ3nQc44vRouxzmHDBbu/5iM+SjTAozx/ICf+A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHSmCmZzQElq5SCVtxXzNtOK0uY1l241cKm26v/N3byI5R87l9vz8W+vdaJQQ+WEdQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB7k8GosQ+RentU4K6It8FgnnYxkby1c27wq4YogNSkHpSOqrkgxtTdJqko0vWPVrw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENeTl4JEASAQ+z889tSRGCmaXnviIAjXGbhieR9A9lg+g/Vt8VoJFVSUxnL3svPP2g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK7gm4yD3K8b5DJ4uHw7OXWQT+8kUgQw8K1bDCspiyVk+qtQsg4ZOYH2QmFKEyU/bw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPWIDJ2ZZcKl0GtXIhDLNNGndHLwn0k8X0lGLFsEeS3QNKsjYJrkLbSf64lK3V2X8g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIL4OvtgDmsSch3NdimNFL+/0uQHDyST7uWny1NJhICzKIpOyR0BtKbODEP4KzEQkA==");
        }
    }
}
