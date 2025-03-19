using HotelAPI.Application.DTOs.Identity;
using HotelAPI.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]

    public class AuthController(IAuthService authService) : ControllerBase
    {

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] RegistrationRequestDTO model)
        {
            await authService.Register(model);
            return Created();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("registerAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromForm] RegistrationRequestDTO model)
        {
            await authService.RegisterAdmin(model);
            return Created();

        }

        [Authorize(Roles = "Manager")]
        [HttpPost("registerManager")]
        public async Task<IActionResult> RegisterManager([FromForm] RegistrationRequestDTO model)
        {
            await authService.RegisterManager(model);
            return Created();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] LoginRequestDTO model)
        {
            var result = await authService.Login(model);
            return Ok(result);

        }
    }
}
