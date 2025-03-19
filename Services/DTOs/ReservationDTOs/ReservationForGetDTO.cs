using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.CustomerDTOs;

namespace HotelAPI.Application.DTOs.ReservationDTOs
{
    public class ReservationForGetDTO
    {
        public Guid ReservationId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public List<CustomerForReservationDTO>? Customers { get; set; }

    }
}
