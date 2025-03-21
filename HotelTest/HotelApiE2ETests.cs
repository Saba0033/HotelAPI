using System.Net.Http.Json;
using HotelAPI;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.AspNetCore.Mvc.Testing;

namespace HotelTest
{
    public class HotelApiE2ETests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient client;
        private readonly IHotelService hotelService;
        public  HotelApiE2ETests(WebApplicationFactory<Program> factory, IHotelService hotelService)
        {
            client = factory.CreateClient();
            this.hotelService = hotelService;
        }

        [Fact]
        public async Task AddGetOneHotel()
        {
            var newHotel = new HotelForCreateDTO
            {
                Name = "E2E Test Hotel2",
                City = "Test City",
                Country = "Test Country",
                Address = "123 Test Street",
                Rating = Hotel.HotelRating.FourStars
            };

            // Send the POST request
            var postResponse = await client.PostAsJsonAsync("/api/hotels", newHotel);
            postResponse.EnsureSuccessStatusCode(); // This ensures the request was successful

            // Deserialize the created hotel (to get its ID)
            var createdHotel = await hotelService.GetAsync(x => x.Name == newHotel.Name);

            Assert.NotNull(createdHotel);
        }

    }
}
