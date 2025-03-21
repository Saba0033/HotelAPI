using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class addingUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users/Customers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAENkXDdM9sCsgZVHI8YKOfyOtZUiXXT1Nd0SKE3tEKQ5PiSxRN2Huxwf7BkcyC3e2Fg==", "GoldenPalaceManager@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEF3STft6RXVXpwy3mhfB470TNTuDQXGUMfTaLgeXLGBJ/qHEJnVyL6zrs32rMhGHiA==", "sekhv23@freeuni.edu.ge" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEHfdbOdE8eo+ocnFQl/BEtJpMEuZDcmg3tpmtwx1/Vy8cqiHisPSNvenD9XuO2ta+g==", "AuraManager@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEBOZrCxDAd/9cgB+yhbBZffaCGKF/e3eFg1exuCGfslmfEEldCgAY7u+Bsb+2V9wjg==", "Nika123@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEJslV6sCSmHMLYXCqVum39TxX9Wxbf3nKXbtdVvCtiJBHD1lS5Ag698E7aZHQc0/6A==", "MogzauriManager@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEAzsTATl9mrN16FRNxxqDUqOKrgB2sdCCh1oFC2+lBgR578o4F/+xRoW4nVeKKpB/w==", "Gio@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAENWp/fmSJ45Cyswuj4ZgCYLp/zgXDT4yTTgBqT7L8QlC0rOGBVxyd2ZN/wHihrSv/A==", "Nino@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEFZHFDfig2MbywnR2KoS0QgGR6z4DEsTkmdpDatu8GGiODMYd4ahUgtqa24Gd5Y4ow==", "Ana@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users/Customers");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAyxjcCc4Ez42pUyGgcgH7vezLIs/1yw19Ps30tDpx1lTM17/XsfKBsTq6EhkDTGKg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAI4sOSKJnZxJSU82jNOxzJ/Jr9wFMMaraSMeRq5w+hDVFbRPeRL/ZlidrgXhgcq7Q==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAAATfrUXFG0XG9GMtdUBIhuuGr9m9y64Izqd2AieWbeiLfXmyC6meOx00hc8e5WLw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOeWHSq2XMhP67n/5hb02nNN1YAX7THGQfs9YHAU7hkMm1wzLMqfFCgmav+QjdP0Dw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDwNBgaHErmmGvvLWMxy620z40FJvzXoRvFaczyN46to7FWMf2GqnE5fOAnj7DALPA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOhTif2yGTHaV+1R7PNQB+85PmYW2LnVr/vMwrzldwhxy2xPjOzTWgvmCXUpshSVew==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEjHIZKgVvHypoXb954DfpAZ20PM+H3VK+SS6JFWvzG0VUypesVi8JOsvoWnSzlXeA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIbXW7e5s07Qxu95mFoCFX2UMssUCcCN+Tzgx4553v81me0fLJLekcL2VMjZ7Ui1kw==");
        }
    }
}
