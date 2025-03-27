using HotelAPI.Application.DTOs.CustomerDTOs;
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

        [HttpPost("register/Customer")]
        public async Task<IActionResult> Register([FromForm]CustomerForCreateDTO model)
        {
            await authService.Register(model);
            return Created();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("register/Admin")]
        public async Task<IActionResult> RegisterAdmin([FromForm] CustomerForCreateDTO model)
        {
            await authService.RegisterAdmin(model);
            return Created();

        }

        [Authorize(Roles = "Manager,Admin")]
        [HttpPost("register/Manager")]
        public async Task<IActionResult> RegisterManager([FromForm] CustomerForCreateDTO model)
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
