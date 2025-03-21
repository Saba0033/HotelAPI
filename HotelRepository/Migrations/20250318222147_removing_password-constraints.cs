using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class removing_passwordconstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA8fh1OYa8AaXKLWiZoKs3MqQttc8FY/6Uf0p33ZqPQ+L2ATTkV/YEINMSt8Aj2NlQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIKFT5yn2GFZYv/q1GUilrsZ6pcR1hhMWNbk0P1fbi7JlYB+HPdl/aSBXk7LWFbZiw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOVC/jFJE2n3glU/oh6UCUcFhs2yibU+qZve/byc3bTeGI57kNazMjSw8n0SHrOQLg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEODDj2epRN1ZFYlYlX7WmIeKbRx+qZ89r5B3VZrX3VXZiKqvVm5xCkXsDuNFF+A4Kg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELOCJlF6QsXPpzrgDt/MqApWbV2Vuafi7QaSzY1hx5HRLFU7V2vuBV1Xeyr5qfMKVQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHUe0NzAxFZ00IiAiDX3zwPQQbx0XUjMUs8muUvpyoHyz7qrcVdbAoZNU/A146J5Pw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELbhGrL5x9sj+PJM/2IV2YRYYp68hK+3lq7yc/sRLm/whTHHMa0MRDfUOkJrELvwHA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAlTvJa1lZnktp2CayAJH518daXYBm5tFlcvzxmVDnYwxq2YMMT9i3dgblCL1pSVEw==");
        }
    }
}
