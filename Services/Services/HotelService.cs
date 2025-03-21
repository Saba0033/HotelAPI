using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Entities;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using Mapster;

namespace HotelServices.Services
{
    public class HotelService 
        : GenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>, IHotelService
    {
        private IGenericRepository<Hotel, HotelForGetDTO> GRepository;
        public HotelService(IGenericRepository<Hotel, HotelForGetDTO> GRepository, IValidator<Hotel> validator) : base(GRepository, validator)
        {
            this.GRepository = GRepository;
        }

        public async Task<List<HotelForGetDTO>> GetHotelsByCityAsync(string city)
        {
            return await GetAllAsync(x => x.City == city, h=> h.Manager);
        }

        public  override async Task UpdateAsync(HotelForUpdateDTO entity)
        {
            var hotel = await GetAsyncWithoutDTO(x => x.HotelId == entity.HotelId);
            if (hotel == null) throw new ArgumentException("Hotel not found");
            if (entity.Address != null) hotel.Address = entity.Address;
            if (entity.City != null) hotel.City = entity.City;
            if (entity.Country != null) hotel.Country = entity.Country;
            if (entity.Name != null) hotel.Name = entity.Name;
            if (entity.Rating != null) hotel.Rating = (Hotel.HotelRating)entity.Rating;
        }

        public async Task<List<HotelForGetDTO>> GetHotelsByCountryAsync(string country)
        {
            return await GetAllAsync(x => x.Country == country, h => h.Manager);
        }

        public async Task<List<HotelForGetDTO>> FilterByRatingAsync(int MinRating, int MaxRating)
        {
            return await GetAllAsync(x => (int)x.Rating >= MinRating && (int)x.Rating <= MaxRating, h => h.Manager);
        }


        //public override async Task DeleteAsync(Expression<Func<Hotel, bool>> predicate)
        //{
        //    var hotel = await GetAsyncWithoutDTO(predicate, h=> h.Rooms.Select(x=> x.Reservations));

        //}
    }
}
