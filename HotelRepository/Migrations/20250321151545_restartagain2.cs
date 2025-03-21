using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class restartagain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEN78YxbwKtuhwVEjiGmg6D877li+aUxtv67eqzoSj04WqtBkWp7WW8optGaUpMbQCg==", "ab9b94f3-8fca-4e78-a754-5f167d322f5d" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEBXuXWkOCp7jD3y0zBny38ZA9ExRZ9J4SQvSkFtqWFXEkCHKBPA/2c6f3TeQbJHjmQ==", "a96ab6aa-8108-4251-bca2-e15e063b8cf9" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEPmMpdRqkn6LDSrQhyoRSNMpR9FEGlJYNE2dKxN4HA7wV9lENNKMH+Ix956GXGqalA==", "c0ae15db-b427-4058-b1cb-ffc70ce4d3f0" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEGVkPINQa8Hn9hVwiKcwhIeR4syms0/QCrtyxRta77sKmE1TenY13Ti1KifoJUSUjQ==", "e22eb089-d52f-47b6-884f-3af9f0e28537" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEMtw9cmcayo+m8kQUSte4SKPwM42HZT1T1VxOhVbAwkjDt3walC8FL3wuEB18bp2qw==", "7e26b943-6a69-458b-b100-748efd53600b" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEMHyKRdcFvRBPSfuQgboED0G/fYyIKyGJHKm8PJK/vE2sjgb2m+LY/j+oh/ZoJ3hlQ==", "678ceb7b-03ef-4520-b594-16d19412fe32" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAELJFbTT75eEVCWPGoR7+rxawpnhiHh1zMNG0pPd9Y8BqpH7xffhN5m18iRCEXWlFnw==", "605f9645-7cd5-440b-b877-3cba40fa57c7" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAENuTQchjAPwRsg6S0WMQdVhmPlujNjyRITxwGS78dQ4L39VS3wmdVdYk1my/kEDD2g==", "b7437a53-191c-487f-a317-3069566e99ca" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
