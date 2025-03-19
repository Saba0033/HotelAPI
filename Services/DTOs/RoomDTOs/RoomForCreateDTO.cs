using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.RoomDTOs
{
    public class RoomForCreateDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid? HotelId { get; set; } 
    }

}
