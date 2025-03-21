using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class removingColumns2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "05f574d4-de44-41f5-a785-0f98cc8ff017", null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ed4fb5a-ad9a-4fa9-afe4-fe397e399489", null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b79c4f5-5525-4fa5-82a7-97754479bfd7", null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a364d075-4ac1-48c9-8ef8-b44f0bfb6410", null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da47227a-908f-468a-b34e-4722994842a1", null });
        }
    }
}
