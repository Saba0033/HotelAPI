using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.RoomDTOs
{
    public class RoomForUpdateDTO
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}
