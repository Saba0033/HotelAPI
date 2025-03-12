using HotelAPI.Application.DTOs.HotelDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelController(IHotelService HotelService, IRoomService RoomService) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Hotel>>> GetAllAsync()
        {
            var result = await HotelService.GetAllAsyncIncludes();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Hotel>> GetAsync(string Id)
        {
            var result = await HotelService.GetAsync(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] HotelForCreateDTO entity)
        {
            await HotelService.AddAsync(entity);
            return (Ok());
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] HotelForUpdateDTO entity)
        {
            await HotelService.UpdateAsync(entity);
            return Ok();
        }

        [HttpDelete(template:"{Id}")]
        public async Task<ActionResult> DeleteAsync(string Id)
        {
            await HotelService.DeleteAsync(Id);
            return Ok();
        }

        [HttpGet(template:"City/{city}")]
        public async Task<ActionResult<List<Hotel>>> GetHotelsByCityAsync(string city)
        {
            var result = await HotelService.GetHotelsByCityAsync(city);
            return Ok(result);
        }

        [HttpGet(template:"Country/{country}")]
        public async Task<ActionResult<List<Hotel>>> GetHotelsByCountryAsync(string country)
        {
            var result = await HotelService.GetHotelsByCountryAsync(country);
            return Ok(result);
        }

        [HttpGet(template:"Rating/{MinRating}/{MaxRating}")]
        public async Task<ActionResult<List<Hotel>>> FilterByRatingAsync(int MinRating, int MaxRating)
        {
            var result = await HotelService.FilterByRatingAsync(MinRating, MaxRating);
            return Ok(result);
        }

        [HttpGet(template: "{id}/Rooms")]
        public async Task<ActionResult<List<Room>>> GetRoomsAsync(string id)
        {
            var result = await RoomService.GetRoomsOfHotel(id);
            return Ok(result);
        }

    }
}
