using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelModels.Entities
{
    public class Manager
    {
        public Guid ManagerId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
