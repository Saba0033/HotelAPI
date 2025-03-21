using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.CustomerReservationDTOs
{
    public class CustomerReservationForGet
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ReservationId { get; set; }
        public Customer? Customer { get; set; }
        public Reservation? Reservation { get; set; }
    }
}
