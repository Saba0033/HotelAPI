using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Entities;

namespace HotelServices.Interfaces
{
    public interface IRoomService : IGenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>
    {
        Task<List<RoomForGetDTO>> GetAllFreeRoomsAsync(DateTime checkIn, DateTime checkOut);
        Task<List<RoomForGetDTO>> GetFreeRoomsOfHotel(string HotelId, DateTime checkIn, DateTime checkOut);
        Task<List<RoomForGetDTO>> GetRoomsOfHotel(string HotelId);
        Task AddReservation(string roomId, ReservationForCreateDTO res, string userId, string userEmail);
    }
}
