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
        private IGenericRepository<Hotel> GRepository;
        public HotelService(IGenericRepository<Hotel> GRepository, IValidator<Hotel> validator) : base(GRepository, validator)
        {
            this.GRepository = GRepository;
        }
        public async Task<List<HotelForGetDTO>> GetAllAsyncIncludes(Expression<Func<Hotel, bool>> Predicate = null)
        {
            var result = await GRepository.GetAllAsync(Predicate,
                h=> h.Rooms, h=> h.Manager);
            var mappedResult = result.Adapt<List<HotelForGetDTO>>();
            return mappedResult;
        }


        public async Task<List<HotelForGetDTO>> GetHotelsByCityAsync(string city)
        {
            return await GetAllAsyncIncludes(x => x.City == city);
        }

        public async Task<List<HotelForGetDTO>> GetHotelsByCountryAsync(string country)
        {
            return await GetAllAsyncIncludes(x => x.Country == country);
        }

        public async Task<List<HotelForGetDTO>> FilterByRatingAsync(int MinRating, int MaxRating)
        {
            return await GetAllAsyncIncludes(x => (int)x.Rating >= MinRating && (int)x.Rating <= MaxRating);
        }
    }
}
