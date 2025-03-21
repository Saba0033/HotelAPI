using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class _12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGylrQOTGLGqaKMHSRCSOnuinYoymg9qIlVIgrH8STSmkAH1DruvyZWpPCdVbPc/7Q==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDWsUp9SN5jQubo/iuxZYR1lkFANO5JVyvO9oR7/3R+VDg9yhBi/JeaCrMuyJcJyTQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHKpBmKmzV1nYvpcZxVtGohZdg8jjXu/JS4PHoLK5nm+KJ7lbRYKPUGX5nI2uoaepg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAdirHEY5URs68ze7aMuUw5tdnunIvYUmUvGM2t0Cp7S5oofUAcuyUAYTzXG7GNDEw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBXxsZl70P/cIvRazqgDz8FNylxl5QeiM7W6xtHX4LH57ZkYBTyz/Pj8p51Cf37JDg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFh7uNKMIxcLML6Wf4PkzZrfffYHmF3VyxVFx4jfhAcKC1Crya6uiHD9B1JH4U6htg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPLETiVq1lCROndlcQpKebeVNkC8DBMA4SRrArcKMj0dB+BFzfn+rVVlvdDSYR/FqQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAd5f6+9Chvs65aY+raELVZPJI2ePRVR829Z2Eg/w9G1GpY3JIEbQWX2HCXeujn53w==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELdXOjNpQd7CXBvlVrqtuVpuasWbSM+qd5UoxCE+pRa9t777PvXUTD6kxaGRvreGWw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH3xL6hnH+UhNLNU/IEvDDcYALKwcC0iHQEqMSg1J0fz246rtoKKUOyAC5RbbyWdXw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAoKu3CvVelaFUw0V9SNbhOyvOBW3SEE575Eqi4aECzDaqs5CZfnIx03nPHKBFW37A==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA0rwV6vzmv64WhYTTDGKidphZ8VR0gf05rnxzZY/dKTPB/NL8HF1iDxaaJMuYEMng==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGwlsXvJTvAQCmg/sX+6quD+WIRQpefo+JZ4mniAEIKYhOT6ukbGimvS/f1805naUQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC7LnwEsjCykj2mw1GmHvQEWUaQ1NQduTyZR5/zBaJGvCjT+fS2dIXDw6JEUoHZfjA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECb9fIzXvPFUr8vwNQe5vrPfbTPtqXm17YtodIbkMQcecIp3MPCIERpZLKsJegw6hQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIKitohnichwdRWSiAugJa6VxWI6Aa6zz4kzgkNiDXJZo0hsGSyHlKpZs5HzgLFn6Q==");
        }
    }
}
