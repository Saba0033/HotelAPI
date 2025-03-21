using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class addingSecurityStampes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAECW21d2Eu3c3+vELOftF0i/6r64KbdeNzyAH2U4o9o6dL1D3GF1LwgCaJ9w0iJ2ntQ==", "b35d61c3-d21b-4d7c-8977-49860bee5f06" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEAokGrrQCm+yNDfDtEeEIOegQfY7cEwliXwSPfFC7Y69Dqsp6+NzB0atWsT6FzECjA==", "0761ec82-5289-4876-a604-8dc2e8b0f7ac" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEBBz95Azu7NPXFqZnJSZL0HaOnhwuIrnbWEHuIRA99ZEQ7y23prmwpmCzhvfj+X2RQ==", "18c135ac-53c2-4a45-b80b-443b1858a18e" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJYPY+2RUojPDDAziY/Bq64cY9w9p9hKxcyotW1C722g1XvcJXT0lpZcTFE+A2MAlA==", "0fb136f7-4e19-4eab-8e5f-caac691d8371" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEG7BtAM9dt31F4GKwLY94jXbUT/RqKN0WorGIWyQTTf3Q+m7PVS2hxANzXQvF080cQ==", "da94aa37-b607-4fd2-83b7-9ec4d579bd09" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEKxbW05tcYah/sFD1xhTS5fcqnmmOQGRVX9Qb2hC2psph3ePdJgJGwEpUH2LO+phdQ==", "1c0c63f1-e48b-434b-98ca-79192fa66f43" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJSEIluTaSl3w22vuKITXquGMlOqAkHv2Bb4vy+DGDgx/yrzykDiNDl/AHKUft6MJA==", "d1623fc9-afed-4dd3-ba55-442c91d95a51" });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEM1+q1ep0NrZA0LS91VftcrHoGDA/faFFj2lSlfZXaozLmxvPAGmin9zQ08jJLXtCQ==", "1343dc65-2f3f-4f39-8b60-33257afff2ab" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAENxJVgdn3J9U4+DkWPE4Rg95o/uV3J2LcX1HXNrbLdC1XqVxwtk3IhI78u96WdyaZg==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAELwZl5WLpro2pYFQGTefx3W9W6zfXqSWmwwGYBLLYfGz6dhk7zWDLJxrIWOId5NnEg==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEA+e9KPAyQdu8xpvdHl3kjUZIY0nwZDft2VVaGLm3hxfuScExhQe5TlAIO4ccRwu+A==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEKyumNL6P9wy3Dr5NyBcA7j7w/tc7ppYVhS7U6QII1rRG+j0hRYSAffkvU+CVGTARQ==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEH9Df23FPZZv0tlA4yFDtUQhh9eiuYrHsvqeT9OfzLldbvxu4J8e3oBWglXru1ZYHQ==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEDM2NzfTZ1qo9by+n0Mpev9iVoorSBWYVRYupuphqqybAu6XaA+e2CJW/CCgfEkDAw==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEKP7cYQguqC61t9MEqhA6l9pcTNlMYCSXLAHEIquRIJPpP/INpoh1abt4CGXOCpQoQ==", null });

            migrationBuilder.UpdateData(
                table: "Users/Customers",
                keyColumn: "Id",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEByXSBzZkw5NkAwbEj5uck03qMIxZcSvjqZKJVP4fiRbLnb8iziTSjoRDmAeCXc47w==", null });
        }
    }
}
