using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class addingNormalizedUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "GOLDENPALACEMANAGER@GMAIL.COM", "AQAAAAIAAYagAAAAEK9hHDJY03XVrh6VsUWW9oXJV87ONOs1nHNjPXRob9yyhv3m9oFbkDVN+QAum/wx5w==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "SEKHV23@FREEUNI.EDU.GE", "AQAAAAIAAYagAAAAEP2g7TSHOqwYQ+7ry8GkzR5gobHlZd/U0Av4Z4/Tf7xpS3up1gviw5ZJbBitlaJ4zw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "AURAMANAGER@GMAIL.COM", "AQAAAAIAAYagAAAAEL6geyXTKxUZOwgWNWl8F/CniIOowuXOpVYDmkg9bKSsUhUwhVW9mgxt0umBjDFoIw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "NIKA123@GMAIL.COM", "AQAAAAIAAYagAAAAEOLRApzNXiTvajZkEF5wk75gMlR2pVN9zNHpYw8NvuVRy9O/KrrD3y2bHA/mnEStxA==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "MOGZAURIMANAGER@GMAIL.COM", "AQAAAAIAAYagAAAAEBFB5cM+G+rn8vZdAldrYhEzHSnpiPzKuOiwdmtJwDXluVSoBKi4AL7oQqCWSzZXOQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "GIO@GMAIL.COM", "AQAAAAIAAYagAAAAELIgIljwUN0nz6zfLY6MsfJOWzptzpiXzuIsEO+3eY2GCP+oenNYVfLI9LZ9BFKNyg==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "NINO@GMAIL.COM", "AQAAAAIAAYagAAAAELR7ABewUwarc1F5YKx+GFzYCkJsFOH8lbifbjISuKvK3vuU0Y9nXR1giDGELHoAnw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { "ANA@GMAIL.COM", "AQAAAAIAAYagAAAAEPuhbfbJkQaf0pPdhxn6lcoYIZtG38RB9m9F+6MqsdvEZXQtpVo2F2RVt/w/GK3dVw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEKom7BlmjBEojASdnq0d1eBez9y7NspdHfjKouBIWu2KO8qzZzAukfq8zKhFTDO0kw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEIqnNeiqDx5HtX/MKzhGq25qiSQTFNiUmJDmILoGjSngUjvGMJyyYQP2HhHy2p5N8A==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEHMilFzy1DM++Es5niVTDR5PWMvD5RMGnim08c8htpBDHzMHICfrlqMyTh2PxyuCQg==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEKTHaoDO6LYyqgxnqMyspc7zcCsiBm6A4dnmnNOW0tAWGrEeBmBA9r9zjxkHferzCA==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEPJUVBy70JMXgH5ycdmXDa+ymPEEqT++O04aSRSDubFxgom7Cr3ID/veCVR23VTVaA==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEGOlArKDHNyIDUrV76FoeQvV2smkWp9P1ru0ZP35qsgCuAXErwH6pmWeE0fUkx7ILQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEEoE6VBYly5z9Vuk+nDo2Bl9ysNGS9j8H429518azm1DIDeIRZn5jOLg7K2+B38jPA==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "NormalizedUserName", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAENym73Zzu7pdli0+neaCuO+Gq/x8jnm5WYo1U4uNOAMfsum7x8+so8lYTA3iQAgGCw==" });
        }
    }
}
