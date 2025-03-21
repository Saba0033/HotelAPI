using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class without : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOpBVX5kjW2+JPMEkay9o2cMqoGXeZX0E7zTw80jfzR2Ze9RQKqRvsOdrB0qCGpXRA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENMD/vzfxYh0whE937xhXEMLdE15yYjTBp5MtceFHTm86YgQrL8sJXcT7FOwiEv7Ig==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBYFn+mxu++1ST/htAARs3cPrKVJYaJHbqHqMhwKnc6jFIt+gaPTbmQCkigkVOoU0w==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA/LiDuOHkCej+1OzK2KK/Kw3H3JqYZJgFE8UUOddhpWPLkZtfvc+CjQ8db+jkXOjw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJluRIMjohcsd6DKZDx5UatXTyj0zwJA1fWQbXJCwPWu/ZyJNC0sg8XD9VhMjWmlsw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB25pYbJTZPAsqaVe5LFiO+qFxWyArMO8TuCl6+5zDxdIaiWgYGtiCrprzu+aFT9Iw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED9xMqqXGmU4xTg3q4kZb1B6fuVKw3wCa4qcmMrLOrg7g4oQEEumDDVExkkgaL4CbA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFw5JhNzygRg6aqO2YXovjlGEUmFImH3yUNY0es4SZG1U1xpUGo3HRMef77+Qs+PUQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
