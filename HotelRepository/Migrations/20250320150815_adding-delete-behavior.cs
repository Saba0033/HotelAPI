using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class addingdeletebehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEOjpQsx2iaAfSFExvJRQYYrfQVJ3nZOjrF+4zAM7/SQKnJkY7Wz77C5fiLGWaEjqiA==", "83f6832b-abe3-4244-9d63-c97fc0f75d90" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEHzaJKjw4Liry+SfQ9c6EN/zU6qOdDxLBs3dn9CY7JjyqJvRasgVAIC4trAOo5eX5w==", "aa5c6818-1627-4bff-9466-c320b4fa8604" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEEnp4QlJvyTHsAve+3/PIuYEeHbPKhXOTj1hCUc/IYD/PP+DOEj4JOTHm6ZEuOclrg==", "139e27fc-81f9-4a0b-8edc-f2243878bf9b" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEElp8kWQaoARsEGZqY2lCI9dEeruDW4c2hbndrUqLu9+NvxsrqlnVSUTb1TLkiK58g==", "67af9ef8-9163-484e-a72d-3e7f05335794" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEI/lNW51rH1KnR/Az2N2ocAi+HePncS6CfgREHG8fdJa8NqvrF4GE5kjZt1I7JzGOQ==", "f2a725f4-d46e-42af-989d-72d97479a9e7" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAENtV9/1MbcICqqyUNGBN/Jn+yJzjcI3LZpPXI2LBs6VVSk3sLqxhn8AMk8Jc15hD/g==", "a0b56181-e43d-421f-9fd6-1c2db6e88cfb" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJo6kZ/bBzVfT/Vt0Mt+5vud7HZri95qYb6AWcmAtV2yxwfpltKR8CjsS3tYTRkoig==", "21ead43c-e8f5-4458-bdfc-ff68cd5c278f" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEHEuQSCc4HCG7GS739fL4tsmaItAEEBgDrh9nuSn1wG7IGgfop757PVzfDRKYsRkgw==", "ffe334d4-531f-49a8-8e80-39507c6f96d3" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAECW21d2Eu3c3+vELOftF0i/6r64KbdeNzyAH2U4o9o6dL1D3GF1LwgCaJ9w0iJ2ntQ==", "b35d61c3-d21b-4d7c-8977-49860bee5f06" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEAokGrrQCm+yNDfDtEeEIOegQfY7cEwliXwSPfFC7Y69Dqsp6+NzB0atWsT6FzECjA==", "0761ec82-5289-4876-a604-8dc2e8b0f7ac" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEBBz95Azu7NPXFqZnJSZL0HaOnhwuIrnbWEHuIRA99ZEQ7y23prmwpmCzhvfj+X2RQ==", "18c135ac-53c2-4a45-b80b-443b1858a18e" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJYPY+2RUojPDDAziY/Bq64cY9w9p9hKxcyotW1C722g1XvcJXT0lpZcTFE+A2MAlA==", "0fb136f7-4e19-4eab-8e5f-caac691d8371" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEG7BtAM9dt31F4GKwLY94jXbUT/RqKN0WorGIWyQTTf3Q+m7PVS2hxANzXQvF080cQ==", "da94aa37-b607-4fd2-83b7-9ec4d579bd09" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEKxbW05tcYah/sFD1xhTS5fcqnmmOQGRVX9Qb2hC2psph3ePdJgJGwEpUH2LO+phdQ==", "1c0c63f1-e48b-434b-98ca-79192fa66f43" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJSEIluTaSl3w22vuKITXquGMlOqAkHv2Bb4vy+DGDgx/yrzykDiNDl/AHKUft6MJA==", "d1623fc9-afed-4dd3-ba55-442c91d95a51" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEM1+q1ep0NrZA0LS91VftcrHoGDA/faFFj2lSlfZXaozLmxvPAGmin9zQ08jJLXtCQ==", "1343dc65-2f3f-4f39-8b60-33257afff2ab" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId");
        }
    }
}
