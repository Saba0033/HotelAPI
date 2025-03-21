using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class restart123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEGoKzTxLm4AC0HDh55cQAN98Pu7w3/JoBLQUn4ycx5XoOGhFgh4URG51Y9Wu6O14pw==", "2f563896-149a-4ef4-9c38-bdd864f72ee0" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEHRNCVMgSo28wAilAEpAwr4YS7DetBy3SIF65M61fWLZorDLFs+PTbEfcwZGvK7jxQ==", "fbc050ac-3bd9-42b2-8946-20f98270cd18" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEEkfI9nqd1oxmjVOWI9MapmHc3RVMYT51QfX4Ti/wSPSsyQ8TrcAUFQGmk+5GxtgiA==", "0d6e071b-fd5e-4b88-9334-f7c9e20db0c5" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEK5ZIUxHeyKhKcSrRQ/i/aLoa2Xd2AEQUO2/glIUfbJKMmgzxjIKWkBG+UsxapJAtQ==", "051fcd43-2d8e-4eac-b989-2dfb0171af33" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEG2A270Y2EsdpRklPR6jAZYM+qr7JWs/Vi6e9RB3EcipidzEl9jdibO2Gxp9+Y8AiQ==", "09563646-aad1-46d6-a099-338d34b66ab7" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEHAmwECaCV9YxIiftwpSe4nDM0FhyyhOPTbjSiUtxpGTKY1n1EKpsJsOQ820v1XeZw==", "80187d1e-b5e3-4de5-bd65-06347958c946" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEDLddPHJ6sn11lKyPAik5we+qR5XPZv6YdccsQdznJDKZ0dInUWNvoV5IVUuIx+wrQ==", "cbfa6c87-717a-4b38-8ca0-696524292443" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEBkAbV75jFTa1qfPbta36/AjE91SjzbV/mUjmy+Sgn+Ox84WAp/9EQ/W+qjel12BWw==", "befb3e82-b530-459c-92fa-da05bbbda2c5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
