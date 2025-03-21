using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class identity4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerReservations_Customers_CustomerId",
                table: "CustomerReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Customers_UserId",
                table: "UserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_IdentityNumber",
                table: "Users",
                newName: "IX_Users_IdentityNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "ConcurrencyStamp",
                value: "a6e1172e-71e8-4f10-a37a-f1ede3e2f564");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "ConcurrencyStamp",
                value: "c0fcb509-efcc-4020-bbcc-378a1d5db575");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "ConcurrencyStamp",
                value: "fec9fab1-b688-4b0a-8da0-43eb02777f17");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "ConcurrencyStamp",
                value: "d546d7bd-9ac1-4e8c-81d2-e68e640557d7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "ConcurrencyStamp",
                value: "7bf9c82d-7155-43e4-947d-8493f1113692");

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

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_IdentityNumber",
                table: "Customers",
                newName: "IX_Customers_IdentityNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Customers_UserId",
                        column: x => x.UserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "ConcurrencyStamp",
                value: "467e5315-d629-4d13-8a80-1a1f4bf151f0");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "ConcurrencyStamp",
                value: "019f1605-284e-4d65-9178-fc53b162b4a2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "ConcurrencyStamp",
                value: "c48f9182-b25a-4dee-a100-20db4091c66b");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "ConcurrencyStamp",
                value: "942eba7c-1a09-4507-b9d6-3822a3ef312d");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "ConcurrencyStamp",
                value: "060efe5e-7ac4-4c1e-be14-d6cf45eb02af");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerReservations_Customers_CustomerId",
                table: "CustomerReservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Customers_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
