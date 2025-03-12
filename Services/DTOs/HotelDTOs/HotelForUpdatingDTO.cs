using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.HotelDTOs
{
    public class HotelForUpdateDTO
    {
        public string? Name { get; set; }
        public Hotel.HotelRating? Rating { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public Guid? ManagerId { get; set; } 
    }

}
