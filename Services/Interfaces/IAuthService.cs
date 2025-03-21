using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.DTOs.Identity;

namespace HotelAPI.Application.Interfaces
{
    public interface IAuthService
    {
        public Task Register(CustomerForCreateDTO model);
        public Task RegisterAdmin(CustomerForCreateDTO model);
        public Task<LoginResponseDTO> Login(LoginRequestDTO model);
        public Task RegisterManager(CustomerForCreateDTO model);

    }
}
