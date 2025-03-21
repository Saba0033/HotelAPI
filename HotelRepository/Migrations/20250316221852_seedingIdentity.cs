using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class seedingIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Managers_HotelId",
                table: "Managers");

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "Managers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "CustomerReservations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "CustomerReservations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "EmailConfirmed", "FirstName", "IdentityNumber", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), "GoldenPalaceManager@gmail.com", false, "John", "12345678999", "Doe", null, null, null, "123456789", null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "AuraManager@gmail.com", false, "Jane", "92345678999", "Chan", null, null, null, "123456789", null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "MogzauriManager@gmail.com", false, "Jack", "99945678903", "Bond", null, null, null, "123456789", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("56789012-6789-6789-6789-678901234567"), null, "Admin", "ADMIN" },
                    { new Guid("67890123-7890-7890-7890-789012345678"), null, "Manager", "MANAGER" },
                    { new Guid("78901234-8901-8901-8901-890123456789"), null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("67890123-7890-7890-7890-789012345678"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("45678901-4567-4567-4567-456789012345") },
                    { new Guid("56789012-6789-6789-6789-678901234567"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("56789012-5678-5678-5678-567890123456") },
                    { new Guid("67890123-7890-7890-7890-789012345678"), new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("67890123-6789-6789-6789-678901234567") },
                    { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("78901234-7890-7890-7890-789012345678") },
                    { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("89012345-8901-8901-8901-890123456789") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Managers_HotelId",
                table: "Managers",
                column: "HotelId",
                unique: true,
                filter: "[HotelId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Managers_HotelId",
                table: "Managers");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("67890123-7890-7890-7890-789012345678"), new Guid("44444444-4444-4444-4444-444444444444") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("45678901-4567-4567-4567-456789012345") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("56789012-6789-6789-6789-678901234567"), new Guid("55555555-5555-5555-5555-555555555555") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("56789012-5678-5678-5678-567890123456") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("67890123-7890-7890-7890-789012345678"), new Guid("66666666-6666-6666-6666-666666666666") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("67890123-6789-6789-6789-678901234567") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("78901234-7890-7890-7890-789012345678") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("89012345-8901-8901-8901-890123456789") });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("56789012-6789-6789-6789-678901234567"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("67890123-7890-7890-7890-789012345678"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("78901234-8901-8901-8901-890123456789"));

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "Managers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationId",
                table: "CustomerReservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "CustomerReservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_HotelId",
                table: "Managers",
                column: "HotelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
