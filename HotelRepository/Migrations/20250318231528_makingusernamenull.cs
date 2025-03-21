using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class makingusernamenull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users/Customers");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECw+sx2QK2iAeosY/XIvuHrjm1j5aOlbFwGZSuCsB4AwQLhnLZFhR8KWaIGE/pzIdA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJk91WF2FVzPb35Z7exaeUjWq7M1CY3LuLB37A6vUIGJmJnSmLWZ+O1l9b/WWaIO+A==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELDFaxc778L5qwQCMBJm+PplLfQffJEqxdqTX70KBGG/qn4nUZcA30UoDrtc8Z6kng==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEG70GWhnXyKLzl709jSsqsrjH+qpRD1unzAfkYfyDusqW22e0jNrov830ZyiUNUsRA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBrjh/shkJDPxoALqCUDFjYTzRyfvmoBLeTw6h9RoT8MM49s8u+oPkvARz+W2TJ0Pw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPMe22HwQ0RWqeReMdhOBQahjEPV9QNxA3cmzUEB6Nt/YGrp3HcgpmbfzULBUHCRpw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBraxUHoqZR62+gDFYKZtddZ/TprKCsK/+QMgfn4aQzVGedLNsaEejJQEDk3kA2wLw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI9RsnVXnjuB4sEqXbFJIEuplTea0xpWWjTCQFb7YS/QeELLdrFSKsUUptSjJ+h2Ew==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "AQAAAAIAAYagAAAAEGHWqmDP+vHnonXc33z7KqzbzBl1OiwH2KTdWkE6lYaHaCWiZV9iH6KaSqkBMwbM2g==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAELyk1XSiWzLHehtGsnl02PW3Vqzx/sepCvLci6UG33YuVqiqLuEnx+zKRaLLuaS2ig==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAELqnrpCgSUEDE03EyfhTEf7zVgq/3mIwzgBO/8HSz96veuipiQ3gLSlymvM/VBeA/A==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEOz0DX5X44AsJUEHJEiF2RmAj2Sf3e+hVd/zdFfuq5Y2sf1k6D72YC37X0cqjmBHdw==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEHuyqV/FIbuw7vy460DY4GI1KTx0L74v45fKnK8qE32WvJ+bUTGVEvdbGa/9K2Y1LQ==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEDOZUn2RYk8o/3vzElwxicxXVe191kP8QeDN8Vf+SqE9mlai7VqL9OJSogpaR+j6lA==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEKye8eQ5esMMvAKlrbj+QNiScjuXfU80GpLWw3djnEC2FF4UrSCyCSzPPsIZjy5E3g==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "UserName" },
                values: new object[] { "AQAAAAIAAYagAAAAEB5oGEqvVYheJj6aroltUmOqmhuaBXceIaksc7CbHhUjDa6zFLZXucV0QtP7/1D5Kg==", null });
        }
    }
}
