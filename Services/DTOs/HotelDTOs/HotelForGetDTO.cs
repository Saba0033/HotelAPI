using HotelAPI.Application.DTOs.RoomDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.HotelDTOs
{
    public class HotelForGetDTO
    {
        public Guid HotelId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; } 
        public ManagerForGettingDTO? Manager { get; set; } 
        public List<RoomForGetDTO>? Rooms { get; set; } 
    }
}
