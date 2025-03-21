using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class addinguniqueindextomanageremail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEPY8GNH0GGxgflkjpBc4QfDo5GMBvvbZJxDhKfk/MtuCwI2uW0uextGUlDXifsx7ZA==", "4fd39bf8-5a04-4b58-82c8-addf25815e95" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEBkoLnir06kNxnyl5jV4r4FS73kwS+DGllif/OFj/V7hh7dmRCaa8Uvpdg7lrYckGg==", "526c62dc-113d-48bf-8c60-376987602090" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEM61z0+/vehC2j26iQBw2njYX+h8T8YzgADku+nIW8i+Mbgv4LUXB0o4BSusb6utYg==", "42dbfd51-faa7-48be-b7b7-578df516ab09" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJTOncoU/RiZtqtIMTjSA4ERtHweQCucXyXyaJyChBJLrL1hnpvPe11b5xZPY0ocsA==", "66ab24fd-ff9c-4ac0-a12b-f3b8244e7bf8" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEMxD+SRNu8awe3CKAVjRz7yFACMI3wrbzOrbVT9lzVUYdT5YtWsZCl/RxOx4/z5Kng==", "284959bf-e170-427a-9305-2be550cd3731" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEMtBJcpVFMKEvAcA/KJqQp4WmZFL6ovXMvqQZko4fapcfZAHINxAlt0i6upAfpLMtw==", "4787c459-1468-4b2d-bd68-eb4a2c85c9c4" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAELgb+T3/X4a5wvh9KdxIfYWMOAu9gZNxjQP9TT7wOUUUGWsTB79yIP6p9FqvWKRDtw==", "81676827-0c6a-4bdc-ba0d-e7e8fb8742e2" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAELXnum4AHSAOl/p9UVG90gRy61s6haxsPbEJsRTkjbTSHivnR8xC8EQsdAzKcA6dlg==", "b8926193-7e55-4b31-8f31-e04b4a4e491b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
