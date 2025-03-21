using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class checkifseededdatawillrestore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJledpaCbnKVJr27OSSgbiWVyeG2GDdpk2m9TC4aWxipMYPdMQKIpMOfe7uz83McAQ==", "d1679d0d-8011-4727-aad5-3f9850af9025" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEE5CKuzkNnk6bWUqWSdjQYRT27Knbs0sSBnyfP9NVdo7YGDDMFCWCDq22PqrD5FbdA==", "8fb18cd9-ee28-41aa-bf63-6b992bd5f79a" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJ8DegiE3mYAs+8rb8eNgTHcUDPr6Z6sGRkbjVHXzzdWkv350YhKgJ9goclMuN+2CQ==", "8e78fc4c-c77e-492c-a063-753c94ea0a78" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEIT3R4Jvc6UzqdX8xZoOkoq9EkXP110JxarQzwCSWKN3saoObG8BVocpGk2U8Ae6tA==", "d72f3930-8a8c-4f9d-ac7b-5c3dcc214f64" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEKZ33f0VAkdke32FRt6nkPeQcjLnsD/rGl6Gzfd9mV9Q9O6LVNqqg1q69O3l7qB9Rw==", "fb906835-9d4b-4d93-bbab-b70e0f488173" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAENYyGGp0qbaShHf2kEN+JaQcSnJEeZKIWS1UNEVtaJJ/U7mM8PDod5Mz2uavIbhvbg==", "a2ef9158-c0c2-40d5-83a1-abcc266093c6" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEHOMI76PB3b85+8VccPf+a+y27zUWsq3TNg4LHa6RVnqakv2ANul7XbO0Q1gZj4Vzw==", "52226c1b-245f-438a-99f1-623b3394f43c" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEAbsBKjypVjBTJaKK3asGVfX2iKgd17t7yn/FEo/pPovAtb4qdXlSdOU+ioYjXMdCg==", "e476683a-5d6d-4d2e-b5ab-d4303862bda9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
