using System.Security.Claims;
using System.Security.Cryptography.Xml;
using HotelAPI.Application.DTOs.ManagerDTOs;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.JsonWebTokens;

namespace HotelAPI.Controllers
{
    [Route("api/hotels/rooms")]
    [ApiController]
    public class RoomController(IRoomService service) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Room>>> GetAllAsync()
        {
            var result = await service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Room>> GetAsync(string Id)
        {
            var result = await service.GetAsync(x=>x.RoomId.ToString() == Id, query => query.Include(r=> r.Reservations));
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<ActionResult> AddAsync([FromBody] RoomForCreateDTO entity)
        {
            await service.AddAsync(entity);
            await service.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<ActionResult> UpdateAsync([FromBody] RoomForUpdateDTO entity)
        {
            await service.UpdateAsync(entity);
            await service.SaveChanges();
            return Ok();
        }

        [HttpDelete(template: "{Id}")]
        public async Task<ActionResult> DeleteAsync(string Id)
        {
            await service.DeleteAsync(x=> x.RoomId.ToString() == Id);
            await service.SaveChanges();
            return Ok();
        }

        [HttpGet(template: "AllFreeRooms/{checkIn}/{checkOut}")]
        public async Task<ActionResult<List<Room>>> GetAllFreeRoomsAsync(DateTime checkIn, DateTime checkOut)
        {
            var result = await service.GetAllFreeRoomsAsync(checkIn, checkOut);
            return Ok(result);
        }



        [HttpGet(template: "priceRange/{from}/{to}")]
        public async Task<ActionResult<List<Room>>> GetAllFreeRoomsAsync(decimal from, decimal to)
        {
            var result = await service.GetAllAsync(x=>x.Price >= from && x.Price <= to);
            return Ok(result);
        }



        [HttpPost(template:"{id}/AddReservation")]
        [Authorize(Roles = "Customer")]
        public async Task<ActionResult<List<Room>>> AddReservation(string id, [FromBody] ReservationForCreateDTO res)
        {
            if (User?.Identity == null || !User.Identity.IsAuthenticated)
            {
                return Unauthorized("User is not authenticated.");
            }

        
            var claims = User.Claims.ToList();
            foreach (var claim in claims)
            {
                Console.WriteLine($"Claim Type: {claim.Type}, Value: {claim.Value}");
            }

    
            var userId = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value ??
                         User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var userEmail = User.FindFirst(JwtRegisteredClaimNames.Email)?.Value ??
                            User.FindFirst(ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User ID not found in token.");
            }
            await service.AddReservation(id, res, userId, userEmail);
            await service.SaveChanges();
            return Ok();
        }





    }
}
