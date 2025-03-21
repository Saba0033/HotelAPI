using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Entities;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;

namespace HotelServices.Services
{
    public class RoomService : GenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>,IRoomService

    {
        public RoomService(IGenericRepository<Room, RoomForGetDTO> repository, IValidator<Room> validator) : base(repository, validator)
        {
        }

        public override async Task UpdateAsync(RoomForUpdateDTO entity)
        {
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

        private async Task<List<RoomForGetDTO>> getFreeRooms(Guid? hotelId, DateTime checkIn, DateTime checkOut)
        {
            return await GetAllAsync(
                room => (hotelId == null || room.HotelId == hotelId) &&
                        room.Reservations.All(resv => resv.CheckIn >= checkOut || resv.CheckOut <= checkIn),
                r => r.Reservations);
        }
    }
}
