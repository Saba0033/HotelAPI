using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class restart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPuFIYssDJgefU25rRqQc1jdGeRUlYa/Ck8FSVU9SZagWR5vMH2tIWPoBDGMFOsKcQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKrL34c8awboSx6VNgWlWJ5bOsZCpZUNPMqnkORjxGG42q146drY4PpHYo9gZx0gAQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHarp6io4F/BhColDAFWLDRDpPlChCw2AI0tnIsP9sA13awkGrN339KmPcHcVJ8/bA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC3KftgSufhCHlrD0Cjf5UAfI8hRmd+98LgDgolavEN3RrPCmUl/ZJH0+g9fnKkpTg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC4lhmQLTkpTI2dN7XoEuREpQJNhihL4Zd/iu97bhIFMaFsxLgdKbw4x2tcz+PVH3g==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEODdb3hNw6RPH83JVgnawubhwaWJ7i6NugJq2wrIYpFlBwcrZsDmCqxujB3Ullswng==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB41Tryti7fvzRYD/K/dB/Uwxg2whNaHibMP3QrJIp4QELIbn4edDFSrWVVvE7V3yA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIQXcKthwrUeFQbawVP9YbVNf8jzKBMpkWk2w+A/3xYjZ4b6I1cXdPFdaEl+Bx8CjA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOpBVX5kjW2+JPMEkay9o2cMqoGXeZX0E7zTw80jfzR2Ze9RQKqRvsOdrB0qCGpXRA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENMD/vzfxYh0whE937xhXEMLdE15yYjTBp5MtceFHTm86YgQrL8sJXcT7FOwiEv7Ig==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBYFn+mxu++1ST/htAARs3cPrKVJYaJHbqHqMhwKnc6jFIt+gaPTbmQCkigkVOoU0w==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA/LiDuOHkCej+1OzK2KK/Kw3H3JqYZJgFE8UUOddhpWPLkZtfvc+CjQ8db+jkXOjw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJluRIMjohcsd6DKZDx5UatXTyj0zwJA1fWQbXJCwPWu/ZyJNC0sg8XD9VhMjWmlsw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB25pYbJTZPAsqaVe5LFiO+qFxWyArMO8TuCl6+5zDxdIaiWgYGtiCrprzu+aFT9Iw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED9xMqqXGmU4xTg3q4kZb1B6fuVKw3wCa4qcmMrLOrg7g4oQEEumDDVExkkgaL4CbA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFw5JhNzygRg6aqO2YXovjlGEUmFImH3yUNY0es4SZG1U1xpUGo3HRMef77+Qs+PUQ==");
        }
    }
}
