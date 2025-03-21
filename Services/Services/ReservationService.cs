using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelModels.Entities;
using HotelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.Interfaces;
using HotelRepository.Interfaces;
using HotelServices.Services;

namespace HotelAPI.Application.Services
{
    public class ReservationService : GenericService<Reservation,
        ReservationForGetDTO,
        ReservationForCreateDTO,
        ReservationForUpdateDTO>, IReservationService
    {
        public ReservationService(IGenericRepository<Reservation, ReservationForGetDTO> repository, IValidator<Reservation> validator) : base(repository, validator)
        {
        }

        public override async Task UpdateAsync(ReservationForUpdateDTO entity)
        {
            var reservation = await GetAsyncWithoutDTO(x => x.ReservationId == entity.ReservationId);
            if (reservation == null) throw new ArgumentException("Reservation not found");
            if (entity.CheckIn != null) reservation.CheckIn = (DateTime)entity.CheckIn;
            if (entity.CheckOut != null) reservation.CheckOut = (DateTime)entity.CheckOut;
            if (entity.RoomId != null) reservation.RoomId = entity.RoomId;
        }
    }
}
