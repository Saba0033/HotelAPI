using HotelModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Interfaces
{
    public interface IJwtGenerator
    {
        public string GenerateToken(Customer user, IEnumerable<string> roles);
    }
}
