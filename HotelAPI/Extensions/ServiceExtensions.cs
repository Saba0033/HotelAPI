using System.Text;
using FluentValidation;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelAPI.Application.Interfaces;
using HotelAPI.Application.Services;
using HotelAPI.Domain.Identity;
using HotelModels.Data;
using HotelModels.Entities;
using HotelRepository.Implementations;
using HotelRepository.Interfaces;
using HotelServices.Interfaces;
using HotelServices.Services;
using HotelServices.Validation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.IdentityModel.Tokens;

namespace HotelAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            // Register repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // Register services
            services.AddScoped<IGenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>, GenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>>();
            services.AddScoped<IGenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>, GenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>>();
            services.AddScoped<IGenericService<Customer, CustomerForGetDTO, CustomerForCreateDTO, CustomerForUpdateDTO>, GenericService<Customer, CustomerForGetDTO, CustomerForCreateDTO, CustomerForUpdateDTO>>();
            services.AddScoped<IGenericService<Reservation, ReservationForGetDTO, ReservationForCreateDTO, ReservationForUpdateDTO>, GenericService<Reservation, ReservationForGetDTO, ReservationForCreateDTO, ReservationForUpdateDTO>>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IManagerService, ManagerService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IAuthService, AuthService>();

            

            services.AddValidatorsFromAssembly(typeof(HotelValidator).Assembly);

        }

        public static void AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentity<Customer, IdentityRole<Guid>>(options =>
                {
                    options.Password.RequireDigit = false; // No numbers required
                    options.Password.RequireLowercase = false; // No lowercase required
                    options.Password.RequireUppercase = false; // No uppercase required
                    options.Password.RequireNonAlphanumeric = false; // No special characters required
                    options.Password.RequiredLength = 1;
                    //options.User.RequireUniqueEmail = true;  // Ensure email is unique
                    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@";  // Allow emails with the standard format
                    //options.User.RequireUniqueEmail = true;
                    
                })
                .AddEntityFrameworkStores<HotelContext>()
                .AddDefaultTokenProviders();

        }

        public static void AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HotelContext>(options =>
                options.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning))
                    .UseSqlServer(configuration.GetConnectionString("HotelDatabase")));

            
        }

        public static void AddJwtOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOptions>(configuration.GetSection("ApiSettings:JwtOptions"));
        }

        public static void AddAuthentication(this WebApplicationBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            var jwtOptions = builder.Configuration.GetSection("ApiSettings:JwtOptions").Get<JwtOptions>()
                             ?? throw new ArgumentNullException("JWT options are missing in configuration.");

            if (string.IsNullOrWhiteSpace(jwtOptions.Secret) || jwtOptions.Secret.Length < 32)
                throw new ArgumentException("JWT Secret must be at least 32 characters for security.");

            var key = Encoding.UTF8.GetBytes(jwtOptions.Secret);

            builder.Services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateIssuerSigningKey = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        RequireExpirationTime = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidAudience = jwtOptions.Audience,
                        ValidIssuer = jwtOptions.Issuer
                    };

                    opt.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            Console.WriteLine($"Authentication failed: {context.Exception.Message}");
                            return Task.CompletedTask;
                        }
                    };
                });

        }

    }
}
