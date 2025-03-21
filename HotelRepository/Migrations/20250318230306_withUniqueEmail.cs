using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class withUniqueEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGHWqmDP+vHnonXc33z7KqzbzBl1OiwH2KTdWkE6lYaHaCWiZV9iH6KaSqkBMwbM2g==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELyk1XSiWzLHehtGsnl02PW3Vqzx/sepCvLci6UG33YuVqiqLuEnx+zKRaLLuaS2ig==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELqnrpCgSUEDE03EyfhTEf7zVgq/3mIwzgBO/8HSz96veuipiQ3gLSlymvM/VBeA/A==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOz0DX5X44AsJUEHJEiF2RmAj2Sf3e+hVd/zdFfuq5Y2sf1k6D72YC37X0cqjmBHdw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHuyqV/FIbuw7vy460DY4GI1KTx0L74v45fKnK8qE32WvJ+bUTGVEvdbGa/9K2Y1LQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDOZUn2RYk8o/3vzElwxicxXVe191kP8QeDN8Vf+SqE9mlai7VqL9OJSogpaR+j6lA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKye8eQ5esMMvAKlrbj+QNiScjuXfU80GpLWw3djnEC2FF4UrSCyCSzPPsIZjy5E3g==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB5oGEqvVYheJj6aroltUmOqmhuaBXceIaksc7CbHhUjDa6zFLZXucV0QtP7/1D5Kg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
