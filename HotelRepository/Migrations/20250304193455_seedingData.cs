using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelRepository.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "IdentityNumber", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("45678901-4567-4567-4567-456789012345"), "sekhv23@freeuni.edu.ge", "Saba", "12345678901", "Ekhvaia", "123456789" },
                    { new Guid("56789012-5678-5678-5678-567890123456"), "Nika123@gmail.com", "Nika", "12345678902", "Kavtaradze", "123456789" },
                    { new Guid("67890123-6789-6789-6789-678901234567"), "Gio@gmail.com", "Giorgi", "12345678903", "Kavtaradze", "123456789" },
                    { new Guid("78901234-7890-7890-7890-789012345678"), "Nino@gmail.com", "Nino", "12345678904", "Kavtaradze", "123456789" },
                    { new Guid("89012345-8901-8901-8901-890123456789"), "Ana@gmail.com", "Ana", "12345678905", "Kavtaradze", "123456789" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "City", "Country", "Name", "Rating" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Paris street 1", "Paris", "France", "Golden Palace", 5 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Rome street 2", "Rome", "Italy", "Hotel Aura", 4 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Tbilisi street 3", "Tbilisi", "Georgia", "Hotel Mogzauri", 2 }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "ManagerId", "Email", "FirsName", "HotelId", "IdentityNumber", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), "GoldenPalaceManager@gmail.com", "John", new Guid("11111111-1111-1111-1111-111111111111"), "12345678901", "Doe", "123456789" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "AuraManager@gmail.com", "Jane", new Guid("22222222-2222-2222-2222-222222222222"), "12345678902", "Chan", "123456789" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "MogzauriManager@gmail.com", "Jack", new Guid("33333333-3333-3333-3333-333333333333"), "12345678903", "Bond", "123456789" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Free", "HotelId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("12345678-1234-1234-1234-1234567890ab"), true, new Guid("33333333-3333-3333-3333-333333333333"), "Room 10", 2000m },
                    { new Guid("23456789-2345-2345-2345-234567890abc"), true, new Guid("33333333-3333-3333-3333-333333333333"), "Room 11", 2500m },
                    { new Guid("34567890-3456-3456-3456-34567890abcd"), true, new Guid("33333333-3333-3333-3333-333333333333"), "Room 12", 3000m },
                    { new Guid("77777777-7777-7777-7777-777777777777"), true, new Guid("11111111-1111-1111-1111-111111111111"), "Room 1", 1000m },
                    { new Guid("88888888-8888-8888-8888-888888888888"), true, new Guid("11111111-1111-1111-1111-111111111111"), "Room 2", 1500m },
                    { new Guid("99999999-9999-9999-9999-999999999999"), true, new Guid("11111111-1111-1111-1111-111111111111"), "Room 3", 500m },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), true, new Guid("22222222-2222-2222-2222-222222222222"), "Room 4", 2000m },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), true, new Guid("22222222-2222-2222-2222-222222222222"), "Room 5", 2500m },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), true, new Guid("22222222-2222-2222-2222-222222222222"), "Room 6", 1000m },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), true, new Guid("33333333-3333-3333-3333-333333333333"), "Room 7", 500m },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), true, new Guid("33333333-3333-3333-3333-333333333333"), "Room 8", 1000m },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), true, new Guid("33333333-3333-3333-3333-333333333333"), "Room 9", 1500m }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CheckIn", "CheckOut", "RoomId" },
                values: new object[,]
                {
                    { new Guid("01234567-0123-0123-0123-012345678901"), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77777777-7777-7777-7777-777777777777") },
                    { new Guid("12345678-2345-2345-2345-234567890123"), new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99999999-9999-9999-9999-999999999999") },
                    { new Guid("23456789-3456-3456-3456-345678901234"), new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("34567890-4567-4567-4567-456789012345"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12345678-1234-1234-1234-1234567890ab") },
                    { new Guid("45678901-5678-5678-5678-567890123456"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34567890-3456-3456-3456-34567890abcd") },
                    { new Guid("56789012-6789-6789-6789-678901234567"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd") },
                    { new Guid("67890123-7890-7890-7890-789012345678"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                    { new Guid("90123456-9012-9012-9012-901234567890"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77777777-7777-7777-7777-777777777777") }
                });

            migrationBuilder.InsertData(
                table: "CustomerReservations",
                columns: new[] { "Id", "CustomerId", "ReservationId" },
                values: new object[,]
                {
                    { new Guid("01234567-1234-1234-1234-123456789012"), new Guid("78901234-7890-7890-7890-789012345678"), new Guid("23456789-3456-3456-3456-345678901234") },
                    { new Guid("12345678-2345-2345-2345-234567890123"), new Guid("89012345-8901-8901-8901-890123456789"), new Guid("34567890-4567-4567-4567-456789012345") },
                    { new Guid("23456789-3456-3456-3456-345678901234"), new Guid("45678901-4567-4567-4567-456789012345"), new Guid("45678901-5678-5678-5678-567890123456") },
                    { new Guid("34567890-4567-4567-4567-456789012345"), new Guid("56789012-5678-5678-5678-567890123456"), new Guid("56789012-6789-6789-6789-678901234567") },
                    { new Guid("45678901-5678-5678-5678-567890123456"), new Guid("67890123-6789-6789-6789-678901234567"), new Guid("67890123-7890-7890-7890-789012345678") },
                    { new Guid("78901234-8901-8901-8901-890123456789"), new Guid("45678901-4567-4567-4567-456789012345"), new Guid("90123456-9012-9012-9012-901234567890") },
                    { new Guid("89012345-9012-9012-9012-901234567890"), new Guid("45678901-4567-4567-4567-456789012345"), new Guid("01234567-0123-0123-0123-012345678901") },
                    { new Guid("90123456-0123-0123-0123-012345678901"), new Guid("67890123-6789-6789-6789-678901234567"), new Guid("12345678-2345-2345-2345-234567890123") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("01234567-1234-1234-1234-123456789012"));

            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("12345678-2345-2345-2345-234567890123"));

            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("23456789-3456-3456-3456-345678901234"));

            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("34567890-4567-4567-4567-456789012345"));

            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("45678901-5678-5678-5678-567890123456"));

            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("78901234-8901-8901-8901-890123456789"));

            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("89012345-9012-9012-9012-901234567890"));

            migrationBuilder.DeleteData(
                table: "CustomerReservations",
                keyColumn: "Id",
                keyValue: new Guid("90123456-0123-0123-0123-012345678901"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "ManagerId",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("23456789-2345-2345-2345-234567890abc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("45678901-4567-4567-4567-456789012345"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("56789012-5678-5678-5678-567890123456"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("67890123-6789-6789-6789-678901234567"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("78901234-7890-7890-7890-789012345678"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("89012345-8901-8901-8901-890123456789"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("01234567-0123-0123-0123-012345678901"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("12345678-2345-2345-2345-234567890123"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("23456789-3456-3456-3456-345678901234"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("34567890-4567-4567-4567-456789012345"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("45678901-5678-5678-5678-567890123456"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("56789012-6789-6789-6789-678901234567"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("67890123-7890-7890-7890-789012345678"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: new Guid("90123456-9012-9012-9012-901234567890"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("12345678-1234-1234-1234-1234567890ab"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("34567890-3456-3456-3456-34567890abcd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));
        }
    }
}
