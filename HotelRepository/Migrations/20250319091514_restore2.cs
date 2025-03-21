using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class restore2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAyxjcCc4Ez42pUyGgcgH7vezLIs/1yw19Ps30tDpx1lTM17/XsfKBsTq6EhkDTGKg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAI4sOSKJnZxJSU82jNOxzJ/Jr9wFMMaraSMeRq5w+hDVFbRPeRL/ZlidrgXhgcq7Q==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAAATfrUXFG0XG9GMtdUBIhuuGr9m9y64Izqd2AieWbeiLfXmyC6meOx00hc8e5WLw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOeWHSq2XMhP67n/5hb02nNN1YAX7THGQfs9YHAU7hkMm1wzLMqfFCgmav+QjdP0Dw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDwNBgaHErmmGvvLWMxy620z40FJvzXoRvFaczyN46to7FWMf2GqnE5fOAnj7DALPA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOhTif2yGTHaV+1R7PNQB+85PmYW2LnVr/vMwrzldwhxy2xPjOzTWgvmCXUpshSVew==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEjHIZKgVvHypoXb954DfpAZ20PM+H3VK+SS6JFWvzG0VUypesVi8JOsvoWnSzlXeA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIbXW7e5s07Qxu95mFoCFX2UMssUCcCN+Tzgx4553v81me0fLJLekcL2VMjZ7Ui1kw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
