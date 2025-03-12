using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Entities;

namespace HotelServices.Interfaces
{
    public interface IHotelService : IGenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>
    {
        Task<List<RoomForGetDTO>> GetFreeRoomsAsync(string id);
        Task<List<HotelForGetDTO>> GetHotelsByCityAsync(string city);
        Task<List<HotelForGetDTO>> GetHotelsByCountryAsync(string country);
        Task<List<HotelForGetDTO>> FilterByRatingAsync(int MinRating, int MaxRating);
        Task<List<HotelForGetDTO>> GetAllAsyncIncludes(Expression<Func<Hotel, bool>> Predicate = null);

    }
}
