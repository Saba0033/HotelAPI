using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.Identity;

namespace HotelAPI.Application.Interfaces
{
    public interface IAuthService
    {
        public Task Register(RegistrationRequestDTO model);
        public Task RegisterAdmin(RegistrationRequestDTO model);
        public Task<LoginResponseDTO> Login(LoginRequestDTO model);
        public Task RegisterManager(RegistrationRequestDTO model);

    }
}
