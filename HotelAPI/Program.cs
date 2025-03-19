using FluentValidation;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.Mapping;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelAPI.Application.Interfaces;
using HotelAPI.Application.Services;
using HotelAPI.Extensions;
using HotelModels.Data;
using HotelModels.Entities;
using HotelRepository.Implementations;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using HotelServices.Services;
using HotelServices.Validation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HotelAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDatabaseServices(builder.Configuration);
            builder.Services.AddIdentityServices();
            builder.Services.AddApplicationServices();
            builder.Services.AddJwtOptions(builder.Configuration);
            MapsterConfig.Configure();
            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            builder.AddAuthentication();
            //builder.Services.AddAuthentication();
            //builder.Services.AddAuthorization();
            var app = builder.Build();


            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }

    }
}
