using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HotelModels.Entities.Hotel;

namespace HotelAPI.Application.DTOs.HotelDTOs
{
    public class HotelForUpdateDTO
    {
        public Guid HotelId { get; set; }
        public string? Name { get; set; }
        public HotelRating? Rating { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }

    }

}
