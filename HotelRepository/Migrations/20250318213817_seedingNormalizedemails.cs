using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class seedingNormalizedemails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "GOLDENPALACEMANAGER@GMAIL.COM", "AQAAAAIAAYagAAAAEA8fh1OYa8AaXKLWiZoKs3MqQttc8FY/6Uf0p33ZqPQ+L2ATTkV/YEINMSt8Aj2NlQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "SEKHV23@FREEUNI.EDU.GE", "AQAAAAIAAYagAAAAEIKFT5yn2GFZYv/q1GUilrsZ6pcR1hhMWNbk0P1fbi7JlYB+HPdl/aSBXk7LWFbZiw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "AURAMANAGER@GMAIL.COM", "AQAAAAIAAYagAAAAEOVC/jFJE2n3glU/oh6UCUcFhs2yibU+qZve/byc3bTeGI57kNazMjSw8n0SHrOQLg==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "NIKA123@GMAIL.COM", "AQAAAAIAAYagAAAAEODDj2epRN1ZFYlYlX7WmIeKbRx+qZ89r5B3VZrX3VXZiKqvVm5xCkXsDuNFF+A4Kg==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "MOGZAURIMANAGER@GMAIL.COM", "AQAAAAIAAYagAAAAELOCJlF6QsXPpzrgDt/MqApWbV2Vuafi7QaSzY1hx5HRLFU7V2vuBV1Xeyr5qfMKVQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "GIO@GMAIL.COM", "AQAAAAIAAYagAAAAEHUe0NzAxFZ00IiAiDX3zwPQQbx0XUjMUs8muUvpyoHyz7qrcVdbAoZNU/A146J5Pw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "NINO@GMAIL.COM", "AQAAAAIAAYagAAAAELbhGrL5x9sj+PJM/2IV2YRYYp68hK+3lq7yc/sRLm/whTHHMa0MRDfUOkJrELvwHA==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { "ANA@GMAIL.COM", "AQAAAAIAAYagAAAAEAlTvJa1lZnktp2CayAJH518daXYBm5tFlcvzxmVDnYwxq2YMMT9i3dgblCL1pSVEw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEF88O5Vs0c1xJzFsFc4gX6cDPhmtBrzl32WJihglTlz77tcKOcJYdytmXbW/5LITyw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEM795J1yiVO+IoO0UwAM05gFU/1oMBoSyrGPBFskd0fMjKid4lxrwuUNxgEcNzlxig==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEP7gKz/2CRg9rexA45YfM4DgP5riCqipQkRfniBAxdjjTtVbYBsv8hdCmN6ucvASAw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEFz5pElG4qOJZi9QmwYUrDEm+WjUs1Qv/0gEzLM2N3NKLtNP6+UgdbkVP7qArpAmSQ==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEIS/qI42E9zCEGjrubL/A036HhOnXU9oP67MyQH3L/uCnIRKYu1mauPN8HRB7rlqbw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEOu7QcqFeNSM+QreNqpXEBE10QKe2Yy3TDdeTqCLX1ayVb6zF+Ca8rVUOHGnoTEJLw==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEIvvG2rEKJ7NDVy1Kso6SGqBwzaZsYTBQ191kWl3a/cwQKGrC40Yz/rvxGAd03r6wA==" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "NormalizedEmail", "PasswordHash" },
                values: new object[] { null, "AQAAAAIAAYagAAAAEIKkyzwF0/8nxxeMRJxULHKarDjCduYKZZoJWNtMNA+mAQWnR8q1QwOqI+O9/6o0Ug==" });
        }
    }
}
