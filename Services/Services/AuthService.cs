using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.DTOs.Identity;
using HotelAPI.Application.Interfaces;
using HotelModels.Entities;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace HotelAPI.Application.Services
{
    public class AuthService(UserManager<Customer> _userManager, 
        SignInManager<Customer> _signInManager, IJwtGenerator jwtGen) : IAuthService
    {
        private const string Admin = "Admin";
        private const string Cust = "Customer";
        private const string Manager = "Manager";


        public async Task Register(CustomerForCreateDTO model)
        {
            if (model.IdentityNumber.ToString().Length != 11) throw new ValidationException("Identity number must be 11 digits long");
            var mapped = model.Adapt<Customer>();
            var result = await _userManager.CreateAsync(mapped, model.Password);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            await _userManager.AddToRoleAsync(mapped, Cust);
        }

        public async Task RegisterAdmin(CustomerForCreateDTO model)
        {
            var existingUser = await _userManager.FindByNameAsync(model.Email);
            if (existingUser != null)
                throw new InvalidOperationException("Admin with this email already exists.");

            var mapped = model.Adapt<Customer>();
            var result = await _userManager.CreateAsync(mapped, model.Password);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            await _userManager.AddToRoleAsync(mapped, Admin);
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO model)
        {
            Customer user = await _userManager.FindByNameAsync(model.Email);
            if (user == null || model.Password == null)
                throw new UnauthorizedAccessException("Invalid email or password");

            var result = await _signInManager.PasswordSignInAsync(user, model.Password,false,false);
            
            if (!result.Succeeded)
                throw new UnauthorizedAccessException("Invalid email or password.");
            var roles = await _userManager.GetRolesAsync(user);
            var token = jwtGen.GenerateToken(user, roles);
            return new LoginResponseDTO()
            {
                Token = token
            };
        }

        public async Task RegisterManager(CustomerForCreateDTO model)
        {
            var existingUser = await _userManager.FindByNameAsync(model.Email);
            if (existingUser != null)
                throw new InvalidOperationException("Manager with this email already exists.");

            var mapped = model.Adapt<Customer>();
            var result = await _userManager.CreateAsync(mapped, model.Password);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            await _userManager.AddToRoleAsync(mapped, Manager);
        }

    }
}
 