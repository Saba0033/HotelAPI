using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class FixingCustomerReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "CustomerReservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReservations_RoomId",
                table: "CustomerReservations",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerReservations_Rooms_RoomId",
                table: "CustomerReservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerReservations_Rooms_RoomId",
                table: "CustomerReservations");

            migrationBuilder.DropIndex(
                name: "IX_CustomerReservations_RoomId",
                table: "CustomerReservations");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "CustomerReservations");
        }
    }
}
