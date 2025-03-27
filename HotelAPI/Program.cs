using FluentValidation;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.Mapping;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelAPI.Application.Interfaces;
using HotelAPI.Application.Services;
using HotelAPI.Extensions;
using HotelAPI.Middleware;
using HotelModels.Data;
using HotelModels.Entities;
using HotelRepository.Implementations;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using HotelServices.Services;
using HotelServices.Validation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Serilog;

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
            builder.ConfigureLogger();
            builder.Services.AddEmailServiceHotelAPI(builder.Configuration);
            
            var app = builder.Build();


            app.UseMiddleware<ExceptionMiddleware>();
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            try
            {
                Log.Information("Application is starting...");
                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

      


    }
}
