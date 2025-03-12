using FluentValidation;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.Mapping;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Data;
using HotelModels.Entities;
using HotelRepository.Implementations;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using HotelServices.Services;
using HotelServices.Validation;

using Microsoft.EntityFrameworkCore;

namespace HotelAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<IGenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>, GenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>>();
            builder.Services.AddScoped<IGenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>, GenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>>();

            builder.Services.AddScoped(typeof(IHotelService), typeof(HotelService));
            builder.Services.AddScoped(typeof(IRoomService), typeof(RoomService));
            builder.Services.AddValidatorsFromAssembly(typeof(HotelValidator).Assembly);
            
            MapsterConfig.Configure();
            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<HotelContext>(options =>
                options.UseSqlServer(
                    "Server=DESKTOP-FLRC66Q\\SQLEXPRESS;DataBase=Hotel;Trusted_Connection=true;TrustServerCertificate=true"));
            var app = builder.Build();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
