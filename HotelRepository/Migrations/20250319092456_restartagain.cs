using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class restartagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELoF4F7AU0aSNsCOIpORr9QBSeUQDDq/RMmXxzzUAV2hIx/HAlozzWlGWYwer8eICQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELuNm/J1MskVC/7S4rb4pyxAz7lnCUvn9Vk+x9yi9LkryGjzhT/wHDbKOHGY8PoH5Q==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPdyeP3jK8RUk+4OS5skBEHrYlUkpkVLns88wsXsv2c7sNrU4phyfg92eejSW2Zkkg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFyRmmOlnPb6NJ5+vfBSkR2VpbdwlW18LFTmMx/BwSjRubAeVdF0XQASxk/q0j/vng==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJxN+GnaJVAClcYo7Q/FtaH14gUGjfR1llK0lgzs1L4xpdjTDQVuutFGGLLZexdkMg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELUgv84kOrPVt6nZtC3k8TnDIiLOe0Ywq5Tf2p/kC5UfyYncxwpnjfs6kO1ORwKlyg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECS4Px9Z88XFDl6VDBMyNqgLc/sUdXGgvwKbFz0ajlbMhpD5XgID05gjcUJxcw88eA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED3ivcijVsJRRjDtmCHHStGUlPesWXpAYNqU51o2Y2ZJxgcwrSueV4B+m1OTrVOiSQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMoDCDbjVW8JyCzwcsV906TFkFXZ+dnhZ/5n4QtoWw8T6Z4YjNBnpZgPY4ACjWJ4rw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMH7i0K6gT3/V5moaZer2aMzkAFm6o5tGQVPP3zpTwRD7WVNR4x6yyC26QS3M/tuVw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN0SqrSWMuP3gCxiK92mZ57jaSSS6ZYnZeOXEo19e8tEEXML1LDn8YEsI5iH70DNjw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIBTyYOAUBG6bzF5lWA9kLCoBEZhF83Cj/jLHr4ax9iHlVBXn5o4UmN45KPdRW/1dg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGYvp4cHAKnS3a68uPCm+ImSL//3xhboqFzliDPflmXFJsSemFKDWZHErkjDHI5r6w==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH3kAYL6DNk3aTWa+vMsAuVMtCdMq1/18rXTNnbBCy6ezjy3EvoFuzuY2mD2x1oSuA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBEwA+mS3zc8vOVPt/N1XXnvbfKykV8UohqsY7ra4vFHHCJj3CuYxVUFCGCLtZ+TIg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAUQpErc8aLWnYHN8cQw4X/yb9K3RuGjLa/c8uogadj2RWPby1ROZkdv8j4yIqzaAw==");
        }
    }
}
