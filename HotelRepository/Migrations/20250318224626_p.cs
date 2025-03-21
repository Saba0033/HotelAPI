using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class p : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGwi+FQroIE/cA65tvI2AvWigJ4q/zNio7Gu1IHash0ssM5oV/Y3in8Dmx//E/nm9g==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMiYfIbMiO2cSTl+FRpqpFKkqqG8EwGVQyZk6Ue1I1e3S9wZEewxS2tbVJKcp7ce4Q==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHAnvGO2wBrhdh/oQlNkrVRrx7QFIjh3uZl7itcUZl2FFmMGr7BUF1Gt64IA4I39vQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKro7NvfNCgVkgdNF/wh+7U+vFsILQjA7Wk6e6YtTOSfuMZozhrm6mrWFUEIDQpqXA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBqHdm1nsSEz1uD1HnnGruCkRDmC1a4idUAqsdJ1DFFdRVBaaLhacjwtxNlcPZQoHQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMfRjdQb7Iam2wj20bsAZJmO7pDmX+lE8OngSkjnMqS8Ru8+m3+CAUcyWu/QhYv3Eg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEASqF9HXkJvq3tjvuoA9aSgTJeoa3tDmruIjILLLr0dLMMNgZ0OIXoOudeoxKxWAkQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOv+aZp4nlp07nPt32WgVuiJrkOLuaB2plCU02W1ebrwP+nA5l5ferbCuhJVwXUWoQ==");
        }
    }
}
