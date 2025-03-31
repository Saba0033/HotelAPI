using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.DTOs.CustomerReservationDTOs;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelAPI.Application.Exceptions;
using HotelAPI.Application.Interfaces;
using HotelModels.Entities;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using Humanizer;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace HotelServices.Services
{
    public class RoomService : GenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>,IRoomService

    {
        private ICustomerReservationService cr;
        private IEmailService emailService;
        private ICustomerService customerService;
        public RoomService(IGenericRepository<Room, RoomForGetDTO> repository,ICustomerReservationService cr, IValidator<Room> validator, IEmailService emailService, ICustomerService customerService) : base(repository, validator)
        {
            this.cr = cr;
            this.emailService = emailService;
            this.customerService = customerService;
        }

        public override async Task UpdateAsync(RoomForUpdateDTO entity)
        {
            await base.ValidateEntityAsync(entity.Adapt<Room>());
            var room = await GetAsyncWithoutDTO(x => x.RoomId == entity.RoomId);
            if (room == null) throw new ArgumentException("Room not found");
            if (entity.Name != null) room.Name = entity.Name;
            if (entity.Price != null) room.Price = (decimal)entity.Price;
            if (entity.HotelId != null) room.HotelId = entity.HotelId;
            
        }

        public async Task<List<RoomForGetDTO>> GetAllFreeRoomsAsync(DateTime checkIn, DateTime checkOut)
        {
            return await getFreeRooms(null,checkIn, checkOut);
        }
        

        public async Task<List<RoomForGetDTO>> GetFreeRoomsOfHotel(string HotelId, DateTime checkIn, DateTime checkOut)
        {
            if (!Guid.TryParse(HotelId, out var validId)) throw new ArgumentException("Invalid GUID format.");
            return await getFreeRooms(validId, checkIn, checkOut);
        }

        public async Task<List<RoomForGetDTO>> GetRoomsOfHotel(string HotelId)
        {
            if (!Guid.TryParse(HotelId, out var validId)) throw new ArgumentException("Invalid GUID format.");

            return await base.GetAllAsync(x => x.HotelId == validId);
        }

        public async Task AddReservation(string roomId, ReservationForCreateDTO res, string userId, string userEmail)
        {
            if (!Guid.TryParse(roomId, out var validId)) throw new ArgumentException("Invalid GUID format.");

            var room = await GetAsyncWithoutDTO(x => x.RoomId == validId, 
                query => query.Include(r => r.Reservations));

            if (room == null) throw new NoMatchFoundException("Room not found");

            if (room.Reservations.All(r => r.CheckIn >= res.CheckOut || r.CheckOut <= res.CheckIn))
            {
                room.Reservations.Add(res.Adapt<Reservation>());
            } else 
                throw new RoomBusyException();

            SaveChanges();
            if (room == null) throw new NoMatchFoundException("Room not found");
            var custRes = new CustomerReservationForCreate()
            {
                CustomerId = Guid.Parse(userId),
                ReservationId = room.Reservations.Last().ReservationId
            };

            await cr.AddAsync(custRes);

            var customer  = await customerService.GetAsync(x => x.Id == Guid.Parse(userId));
            await emailService.SendEmailAsync(userEmail, "Reservation Confirmation", res.CheckIn , res.CheckOut, customer.FirstName, room.Name);
        }

        private async Task<List<RoomForGetDTO>> getFreeRooms(Guid? hotelId, DateTime checkIn, DateTime checkOut)
        {
            return await GetAllAsync(
                room => (hotelId == null || room.HotelId == hotelId) &&
                        room.Reservations.All(resv => resv.CheckIn >= checkOut || resv.CheckOut <= checkIn),
                query => query.Include(r => r.Reservations));
        }
    }
}
