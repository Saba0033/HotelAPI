using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.CustomerDTOs
{
    public class CustomerForUpdateDTO
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IdentityNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public List<CustomerReservation>? CustomerReservations { get; set; }
    }
}