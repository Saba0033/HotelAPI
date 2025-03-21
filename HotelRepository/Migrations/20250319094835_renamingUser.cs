using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class renamingUser : Migration
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
                value: "AQAAAAIAAYagAAAAEB/wlJTpsJ+LK3hJNSSZjAhokK8ZXGH/3ZtSr/6v20HIQD/ClhdupPqMSYjzKRTRsA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECP/k8iyEHL3KlTeu76TqqjNwmOwL0M0kI1DbyPkAxYvFXPEwfIhnGH8JfsuK4y12Q==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJDCDsVcPmt1oQA4lSVY1g2TcGzwIj8paWniwpCuje/W3qEv4/fKsk/1AzkYZyNkaQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHrX9RVOI83YSFwVCwf8FTvGEtmOvOo4HaJRWXlGySmX40zH5J52YvBMsUU0a2ENVQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGGv0OBvB///E59p1vsXxqJ+9OQRpRxKA2ue63YmvsUmW0Lss7nh7nQlS7cQW5C3mw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJKkw/vXj7sk4Mw0F4d2G8l3csLPWUyvJL5495N5WXbSepKwS0ZemETUQd9Dj/e1A==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOZFBAXWFN0BjgiaprLTecnITgoPEi/2Jf19hAsSfU0dQ+o/81EmxnxyAPv27ahnXA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECXG8SA+9y0FkOIiqPimoZ/wOyclzlJ9t9/DObGcyfu4bIKPVfyJhwf3467bpQdH8Q==");

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
                value: "AQAAAAIAAYagAAAAEAFuWoun3T6BINYbYTUN11+YMjjaV+32Fm3qozl0qNubJ5AAA0WFkzCqCAkuHY88fw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMjlOYQM9HreowuB2Bcp7VPZI9u0w823QWHgIrrwEMSHpaBt/4XRcFPxn2YlXg6YDg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPZ6U0Eb5YHKPQprXgf9akZS3WtoM6dL5qESIZrG59xhDLdkhXb77sBfySIN7BbnGQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA8JYirNVnrr6EXV2gHAEgarxR/TsLPdiUPT63MgRFFsotSEVz1XKx9RwaHkWo8Gww==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIrmjqgU4u1xz6fDAE/oXNQjFkS1wMT7HkKlt+xk9RrXRAoVqOz43oLDBoVSJN8ncg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIXFY/bR/7kLDujx4/bX7Fyv9lEhAsFQ4ZjbPFC7c6qIsOQ18l6dPl3wHtEDZaJseQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDdo/BX3TU0myLaC4gruYCJNvDfmBYM9sPlRgEk05Yv1nCqAFhaRxPhVlT2iAun4aQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFR2EKhWFccgOva6+mG8V8i0dz5xwsDsTEHyHIbXt9amwNMk7Mz9tO3VkqgRIDs0Ow==");

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
