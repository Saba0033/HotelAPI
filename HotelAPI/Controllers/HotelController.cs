using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.ManagerDTOs;
using HotelAPI.Application.Interfaces;
using HotelModels.Entities;
using HotelServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.ProjectModel;

namespace HotelAPI.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelController(IHotelService hotelService, 
        IRoomService roomService, 
        ICustomerService customerService, 
        IReservationService reservationService,
        IManagerService managerService,
        IAuthService authService) : ControllerBase
    {
        //To DO
        // customer and room delete, 4,5    
        [HttpGet]
        public async Task<ActionResult<List<Hotel>>> GetAllAsync()
        {
            var result = await hotelService.GetAllAsync(null, query =>query.Include(h=>h.Manager));
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Hotel>> GetAsync(string Id)
        {
            var result = await hotelService.GetAsync(x=>x.HotelId.ToString() == Id, 
                query => query.Include(h => h.Manager).Include(h=> h.Rooms));
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AddAsync([FromBody] HotelForCreateDTO entity)
        {

            await hotelService.AddAsync(entity);
            await hotelService.SaveChanges();
            return (Ok());
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateAsync([FromBody] HotelForUpdateDTO entity)
        {
            await hotelService.UpdateAsync(entity);
            await hotelService.SaveChanges();
            return Ok();
        }

        [HttpDelete(template:"{Id}")]
        [Authorize(Roles = "Admin")]
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
            var result = await customerService.GetAllAsync(c=>  c.CustomerReservations.Any(cr => cr.Reservation.Room.HotelId.ToString() == hotelId));
             
            return Ok(result);
        }


        [HttpGet(template: "{hotelId}/Reservations")]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult<List<Reservation>>> GetReservations(string hotelId)
        {
            var result = await reservationService.GetAllAsync(x => x.Room.HotelId.ToString() == hotelId,
                query => query.Include(x => x.Customers).ThenInclude(cr => cr.Customer));
            return Ok(result);
        }

        [HttpGet(template: "{hotelId}/Manager")]
        public async Task<ActionResult> GetManager(string hotelId)
        {
            var result = await managerService.GetAsync(x => x.HotelId.ToString() == hotelId);
            return Ok(result);
        }

        [HttpPut(template: "updateManager")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<ActionResult> ChangeManager([FromBody] ManagerForUpdateDTO manager)
        {
            await managerService.UpdateAsync(manager);
            await managerService.SaveChanges();
            return Ok();
        }


        [HttpPost(template: "addManager")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<ActionResult> AddManager([FromBody] ManagerForCreateDTO manager)
        {
            await managerService.AddAsync(manager);
            await managerService.SaveChanges();
            return Ok();
        }


        [HttpDelete(template: "{hotelId}/DeleteManager")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<ActionResult> DeleteManager(string hotelId)
        {
            await managerService.DeleteAsync(m=> m.HotelId.ToString() == hotelId);
            await managerService.SaveChanges();
            return Ok();
        }


        [HttpDelete(template: "{customerId}/DeleteCustomer")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteCustomer(string customerId)
        {
            await customerService.DeleteAsync(x => x.Id.ToString() == customerId);
            await customerService.SaveChanges();
            return Ok();
        }

    }
}
