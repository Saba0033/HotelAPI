using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.ReservationDTOs;

namespace HotelAPI.Application.DTOs.RoomDTOs
{
    public class RoomForGetDTO
    { 
        public Guid RoomId { get; set; }
        public string HotelId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ReservationForGetDTO>? Reservations { get; set; }
    }

}
