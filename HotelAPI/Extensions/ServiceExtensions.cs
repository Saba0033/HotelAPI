using System.Configuration;
using System.Text;
using FluentValidation;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.DTOs.CustomerReservationDTOs;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.ManagerDTOs;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelAPI.Application.Interfaces;
using HotelAPI.Application.Services;
using HotelAPI.Domain.Email;
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
using Serilog;

namespace HotelAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            // Register repositories
            services.AddScoped<IGenericRepository<Hotel, HotelForGetDTO>, GenericRepository<Hotel, HotelForGetDTO >>();
            services.AddScoped<IGenericRepository<Room, RoomForGetDTO>, GenericRepository<Room, RoomForGetDTO>>();
            services.AddScoped<IGenericRepository<Customer, CustomerForGetDTO>, GenericRepository<Customer, CustomerForGetDTO>>();
            services.AddScoped<IGenericRepository<Reservation, ReservationForGetDTO>, GenericRepository<Reservation, ReservationForGetDTO>>();
            services.AddScoped<IGenericRepository<Manager, ManagerForGettingDTO>, GenericRepository<Manager, ManagerForGettingDTO>>();
            services.AddScoped<IGenericRepository<CustomerReservation, CustomerReservationForGet>, GenericRepository<CustomerReservation, CustomerReservationForGet>>();
            // Register services
            services.AddScoped<IGenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>, GenericService<Hotel, HotelForGetDTO, HotelForCreateDTO, HotelForUpdateDTO>>();
            services.AddScoped<IGenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>, GenericService<Room, RoomForGetDTO, RoomForCreateDTO, RoomForUpdateDTO>>();
            services.AddScoped<IGenericService<Customer, CustomerForGetDTO, CustomerForCreateDTO, CustomerForUpdateDTO>, GenericService<Customer, CustomerForGetDTO, CustomerForCreateDTO, CustomerForUpdateDTO>>();
            services.AddScoped<IGenericService<Reservation, ReservationForGetDTO, ReservationForCreateDTO, ReservationForUpdateDTO>, GenericService<Reservation, ReservationForGetDTO, ReservationForCreateDTO, ReservationForUpdateDTO>>();
            services.AddScoped<IGenericService<Manager, ManagerForGettingDTO, ManagerForCreateDTO,ManagerForUpdateDTO>, GenericService<Manager, ManagerForGettingDTO, ManagerForCreateDTO, ManagerForUpdateDTO>>();
            services.AddScoped<IGenericService<CustomerReservation,  CustomerReservationForGet,CustomerReservationForCreate, CustomerReservationForUpdate>, GenericService<CustomerReservation,  CustomerReservationForGet,CustomerReservationForCreate, CustomerReservationForUpdate>>();
            
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerReservationService, CustomerReservationService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IManagerService, ManagerService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IAuthService, AuthService>();

       

            services.AddValidatorsFromAssembly(typeof(HotelValidator).Assembly);

        }

        public static void CreateOrUpdateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                try
                {
                    var context = serviceProvider.GetRequiredService<HotelContext>();
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred during database initialization: {ex.Message}");
                }
            }
        }

        public static void AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentity<Customer, IdentityRole<Guid>>(options =>
                {
                    options.Password.RequireDigit = false; 
                    options.Password.RequireLowercase = false; 
                    options.Password.RequireUppercase = false; 
                    options.Password.RequireNonAlphanumeric = false; 
                    options.Password.RequiredLength = 1;
                    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@"; 
                    
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

        public static void AddEmailServiceHotelAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddScoped<IEmailService, EmailService>();
        }
        public static void ConfigureLogger(this WebApplicationBuilder builder)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                //.WriteTo.File("C:\\Users\\Saba\\desktop\\hotelAPI\\HotelAPI\\Logs\\logs.txt")
                .WriteTo.Console()
                .CreateLogger();
            builder.Services.AddSingleton<ILoggerFactory>(new LoggerFactory().AddSerilog());
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
