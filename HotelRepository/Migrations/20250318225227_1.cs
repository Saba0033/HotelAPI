using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELdXOjNpQd7CXBvlVrqtuVpuasWbSM+qd5UoxCE+pRa9t777PvXUTD6kxaGRvreGWw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH3xL6hnH+UhNLNU/IEvDDcYALKwcC0iHQEqMSg1J0fz246rtoKKUOyAC5RbbyWdXw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAoKu3CvVelaFUw0V9SNbhOyvOBW3SEE575Eqi4aECzDaqs5CZfnIx03nPHKBFW37A==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA0rwV6vzmv64WhYTTDGKidphZ8VR0gf05rnxzZY/dKTPB/NL8HF1iDxaaJMuYEMng==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGwlsXvJTvAQCmg/sX+6quD+WIRQpefo+JZ4mniAEIKYhOT6ukbGimvS/f1805naUQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC7LnwEsjCykj2mw1GmHvQEWUaQ1NQduTyZR5/zBaJGvCjT+fS2dIXDw6JEUoHZfjA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECb9fIzXvPFUr8vwNQe5vrPfbTPtqXm17YtodIbkMQcecIp3MPCIERpZLKsJegw6hQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIKitohnichwdRWSiAugJa6VxWI6Aa6zz4kzgkNiDXJZo0hsGSyHlKpZs5HzgLFn6Q==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGt/FgxNJmj35r/pyAVJVqEtf6uPvF0EbcMinFjnl8D16UjS6oZAStpvgwmCwfsfmg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFig2C4j/wwMmgo4zozaM/LJv04sMSVaTxU8hhFb4vLqNa7cWV592FhIVqVeOtL8kA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELPLfm+N011txiGL3fMl/XR7tukKVJNAEpoAraVjpnhSSNLaoP0OrcrHYon50smQOQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKRpC2eN6m+PDKl91Rqw9B9pHxxSRsiWMVnNXv9YtmJNuAY93M7ZBVIHCsvUKQXm/A==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJiKQpSKt/6/P3h4XaLJPwJl+RD5YDugQlLz90rwovopKcZBITAnjWYWmt/y9NlGpA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDtAai4AV3oMKGG+M/3SEcU90yKe0Js5FeCpnwFrfZ+LCUvmVwrTVj5IY6a4rGpIeA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELKu0MEOJAr5VC2Ir27nAbSO7+FF17I0geI8+rQFSUfVl0uCBSouy/TbbiUpTzXVUQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE3HytKVVcN/hdw+iEnookLynWit45CSFeB+TsrIbdqOYhPL6r0s/LlWfpiBUGX/Xw==");
        }
    }
}
