using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.ManagerDTOs;
using HotelAPI.Application.Interfaces;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.ProjectModel;

namespace HotelAPI.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelController(IHotelService hotelService, 
        IRoomService roomService, 
        ICustomerService customerService, 
        IReservationService reservationService,
        IManagerService managerService) : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<List<Hotel>>> GetAllAsync()
        {
            //var result = await hotelService.GetAllAsyncIncludes();
            var result = await hotelService.GetAllAsync(null, h=>h.Manager);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Hotel>> GetAsync(string Id)
        {
            var result = await hotelService.GetAsync(x=>x.HotelId.ToString() == Id, hotel => hotel.Rooms, h=> h.Manager, hotel => hotel.Rooms.Select(x => x.Reservations));
            return Ok(result);
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> AddAsync([FromBody] HotelForCreateDTO entity)
        {
            await hotelService.AddAsync(entity);
            await hotelService.SaveChanges();
            return (Ok());
        }

        [HttpPut]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateAsync([FromBody] HotelForUpdateDTO entity)
        {
            await hotelService.UpdateAsync(entity);
            await hotelService.SaveChanges();
            return Ok();
        }

        [HttpDelete(template:"{Id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteAsync(string Id)
        {
            await hotelService.DeleteAsync(x=>x.HotelId.ToString() == Id);
            await hotelService.SaveChanges();

            return Ok();
        }

        [HttpGet(template:"City/{city}")]
        public async Task<ActionResult<List<Hotel>>> GetHotelsByCityAsync(string city)
        {
            var result = await hotelService.GetHotelsByCityAsync(city);
            return Ok(result);
        }

        [HttpGet(template:"Country/{country}")]
        public async Task<ActionResult<List<Hotel>>> GetHotelsByCountryAsync(string country)
        {
            var result = await hotelService.GetHotelsByCountryAsync(country);
            return Ok(result);
        }

        [HttpGet(template:"Rating/{MinRating}/{MaxRating}")]
        public async Task<ActionResult<List<Hotel>>> FilterByRatingAsync(int MinRating, int MaxRating)
        {
            var result = await hotelService.FilterByRatingAsync(MinRating, MaxRating);
            return Ok(result);
        }

        [HttpGet(template: "{id}/Rooms")]
        public async Task<ActionResult<List<Room>>> GetRoomsAsync(string id)
        {
            var result = await roomService.GetRoomsOfHotel(id);
            return Ok(result);
        }

        [HttpGet(template:"{hotelId}/Customers")]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult<List<Customer>>> GetCustomers(string hotelId)
        {
            var result = await customerService.GetAllAsync(c=>  c.CustomerReservations.Any(cr => cr.Reservation.Room.HotelId.ToString() == hotelId), 
        includeProperties: c => c.CustomerReservations);
             
            return Ok(result);
        }


        [HttpGet(template: "Reservations")]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult<List<Reservation>>> GetReservations()
        {
            var result = await reservationService.GetAllAsync(null,
                k => k.Customers);
            return Ok(result);
        }


        [HttpGet(template: "updateManager")]
        public async Task<ActionResult> ChangeManager([FromBody] ManagerForUpdateDTO manager)
        {
            await managerService.UpdateAsync(manager);
            await managerService.SaveChanges();
            return Ok();
        }


        [HttpGet(template: "addManager")]
        public async Task<ActionResult> ChangeManager([FromBody] ManagerForCreateDTO manager)
        {
            await managerService.AddAsync(manager);
            await managerService.SaveChanges();
            return Ok();
        }



    }
}
