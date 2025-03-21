using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class restart3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEAFuWoun3T6BINYbYTUN11+YMjjaV+32Fm3qozl0qNubJ5AAA0WFkzCqCAkuHY88fw==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEMjlOYQM9HreowuB2Bcp7VPZI9u0w823QWHgIrrwEMSHpaBt/4XRcFPxn2YlXg6YDg==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEPZ6U0Eb5YHKPQprXgf9akZS3WtoM6dL5qESIZrG59xhDLdkhXb77sBfySIN7BbnGQ==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEA8JYirNVnrr6EXV2gHAEgarxR/TsLPdiUPT63MgRFFsotSEVz1XKx9RwaHkWo8Gww==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEIrmjqgU4u1xz6fDAE/oXNQjFkS1wMT7HkKlt+xk9RrXRAoVqOz43oLDBoVSJN8ncg==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEIXFY/bR/7kLDujx4/bX7Fyv9lEhAsFQ4ZjbPFC7c6qIsOQ18l6dPl3wHtEDZaJseQ==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEDdo/BX3TU0myLaC4gruYCJNvDfmBYM9sPlRgEk05Yv1nCqAFhaRxPhVlT2iAun4aQ==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEFR2EKhWFccgOva6+mG8V8i0dz5xwsDsTEHyHIbXt9amwNMk7Mz9tO3VkqgRIDs0Ow==", null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
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
                value: "AQAAAAIAAYagAAAAEL9WTDtptfA0Ury3GlKBKqqiiGiCejrGkGCf8waY26HqwVYldSKs9rgLC1hYlx4O1w==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGt+ho18hW/reXesZ6cV+taSc0Hy3Hu1jCYclMu1UTtqqJmNnyg4s821YFiEJvoJhQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB4QUNzrfsUPH3a+QVqA4xYH08pxA5lvn4T8sIpNdBar913/Gd/GPGGwniB/9V2P/Q==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP/xt1F9oCpNDEvIHWgmCyLWMa6gDcbU18x2UpIHtT8zV6tbnTNCs5IFfTMNEY3fNA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEECMfGeR8GI7EGRH42JxaZCpRXVDDxUT8Qx3vKeleG8oL/KvErNEJPQT+B6zHwP4jQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEORpuKNufLjUkWoFamCi1Bde2bVku/oxEqdrPjVCFJcueKrzgGwbJZLaPvbS8cHWOQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEF/q0cZpEaepLXiaoLdr9tGxge0xeCG2VNZOX4bXwiqmkGNnXXA9ikBCyJT42Inqvw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFD6GSWGfMTxbnD1yqhWCeaY//PBODoEzPd/x5xYHZBoyvSDM2V4cquknlEJe40E5A==");

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
    }
}
