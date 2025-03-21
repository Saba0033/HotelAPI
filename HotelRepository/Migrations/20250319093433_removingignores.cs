using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class removingignores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users/Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEL9WTDtptfA0Ury3GlKBKqqiiGiCejrGkGCf8waY26HqwVYldSKs9rgLC1hYlx4O1w==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEGt+ho18hW/reXesZ6cV+taSc0Hy3Hu1jCYclMu1UTtqqJmNnyg4s821YFiEJvoJhQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEB4QUNzrfsUPH3a+QVqA4xYH08pxA5lvn4T8sIpNdBar913/Gd/GPGGwniB/9V2P/Q==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEP/xt1F9oCpNDEvIHWgmCyLWMa6gDcbU18x2UpIHtT8zV6tbnTNCs5IFfTMNEY3fNA==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEECMfGeR8GI7EGRH42JxaZCpRXVDDxUT8Qx3vKeleG8oL/KvErNEJPQT+B6zHwP4jQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEORpuKNufLjUkWoFamCi1Bde2bVku/oxEqdrPjVCFJcueKrzgGwbJZLaPvbS8cHWOQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEF/q0cZpEaepLXiaoLdr9tGxge0xeCG2VNZOX4bXwiqmkGNnXXA9ikBCyJT42Inqvw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "AccessFailedCount", "PasswordHash" },
                values: new object[] { 0, "AQAAAAIAAYagAAAAEFD6GSWGfMTxbnD1yqhWCeaY//PBODoEzPd/x5xYHZBoyvSDM2V4cquknlEJe40E5A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users/Customers");

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
    }
}
