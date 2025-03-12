using System.Security.Cryptography.Xml;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/hotels/rooms")]
    [ApiController]
    public class RoomController(IRoomService service) : ControllerBase
    {
        private IRoomService service = service;


        [HttpGet]
        public async Task<ActionResult<List<Room>>> GetAllAsync()
        {
            var result = await service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Room>> GetAsync(string Id)
        {
            var result = await service.GetAsync(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] RoomForCreateDTO entity)
        {
            await service.AddAsync(entity);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] RoomForUpdateDTO entity)
        {
            await service.UpdateAsync(entity);
            return Ok();
        }

        [HttpDelete(template: "{Id}")]
        public async Task<ActionResult> DeleteAsync(string Id)
        {
            await service.DeleteAsync(Id);
            return Ok();
        }

        [HttpGet(template: "AllFreeRooms/{checkIn}/{checkOut}")]
        public async Task<ActionResult<List<Room>>> GetAllFreeRoomsAsync(DateTime checkIn, DateTime checkOut)
        {
            var result = await service.GetAllFreeRoomsAsync(checkIn, checkOut);
            return Ok(result);
        }

        [HttpGet(template: "HotelFreeRooms/{id}/{checkIn}/{checkOut}")]
        public async Task<ActionResult<List<Room>>> GetFreeRoomsOfHotel(string id, DateTime checkIn, DateTime checkOut)
        {
            var result = await service.GetFreeRoomsOfHotel(id, checkIn, checkOut);
            return Ok(result);
        }


        [HttpGet(template: "HotelRooms/{id}")]
        public async Task<ActionResult<List<Room>>> GetRoomsOfHotel(string id)
        {
            var result = await service.GetRoomsOfHotel(id);
            return Ok(result);
        }
    }
}
