using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class changingPasswords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENxJVgdn3J9U4+DkWPE4Rg95o/uV3J2LcX1HXNrbLdC1XqVxwtk3IhI78u96WdyaZg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELwZl5WLpro2pYFQGTefx3W9W6zfXqSWmwwGYBLLYfGz6dhk7zWDLJxrIWOId5NnEg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA+e9KPAyQdu8xpvdHl3kjUZIY0nwZDft2VVaGLm3hxfuScExhQe5TlAIO4ccRwu+A==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKyumNL6P9wy3Dr5NyBcA7j7w/tc7ppYVhS7U6QII1rRG+j0hRYSAffkvU+CVGTARQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH9Df23FPZZv0tlA4yFDtUQhh9eiuYrHsvqeT9OfzLldbvxu4J8e3oBWglXru1ZYHQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDM2NzfTZ1qo9by+n0Mpev9iVoorSBWYVRYupuphqqybAu6XaA+e2CJW/CCgfEkDAw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKP7cYQguqC61t9MEqhA6l9pcTNlMYCSXLAHEIquRIJPpP/INpoh1abt4CGXOCpQoQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEByXSBzZkw5NkAwbEj5uck03qMIxZcSvjqZKJVP4fiRbLnb8iziTSjoRDmAeCXc47w==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK9hHDJY03XVrh6VsUWW9oXJV87ONOs1nHNjPXRob9yyhv3m9oFbkDVN+QAum/wx5w==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP2g7TSHOqwYQ+7ry8GkzR5gobHlZd/U0Av4Z4/Tf7xpS3up1gviw5ZJbBitlaJ4zw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL6geyXTKxUZOwgWNWl8F/CniIOowuXOpVYDmkg9bKSsUhUwhVW9mgxt0umBjDFoIw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOLRApzNXiTvajZkEF5wk75gMlR2pVN9zNHpYw8NvuVRy9O/KrrD3y2bHA/mnEStxA==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBFB5cM+G+rn8vZdAldrYhEzHSnpiPzKuOiwdmtJwDXluVSoBKi4AL7oQqCWSzZXOQ==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELIgIljwUN0nz6zfLY6MsfJOWzptzpiXzuIsEO+3eY2GCP+oenNYVfLI9LZ9BFKNyg==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELR7ABewUwarc1F5YKx+GFzYCkJsFOH8lbifbjISuKvK3vuU0Y9nXR1giDGELHoAnw==");

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPuhbfbJkQaf0pPdhxn6lcoYIZtG38RB9m9F+6MqsdvEZXQtpVo2F2RVt/w/GK3dVw==");
        }
    }
}
