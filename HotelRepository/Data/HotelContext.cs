using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Domain;
using HotelModels.Entities;
using HotelRepository.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelModels.Data
{
    public class HotelContext : IdentityDbContext<Customer, IdentityRole<Guid>, Guid>
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureEntities();
            modelBuilder.SeedData();
        }

        public DbSet<Entities.Customer> Customers { get; set; }
        public DbSet<Entities.CustomerReservation> CustomerReservations { get; set; }
        public DbSet<Entities.Manager> Managers { get; set; }
        public DbSet<Entities.Reservation> Reservations { get; set; }
        public DbSet<Entities.Hotel> Hotels { get; set; }
        public DbSet<Entities.Room> Rooms { get; set; }

    }
}
