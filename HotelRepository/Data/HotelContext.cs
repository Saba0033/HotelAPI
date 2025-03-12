using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModels.Entities;
using HotelRepository.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelModels.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureEntities();
            modelBuilder.SeedData();
            //modelBuilder.Entity<Hotel>()
            //    .Navigation(h => h.Rooms)
            //    .AutoInclude();  // Auto-include Rooms every time Hotel is queried

            //modelBuilder.Entity<Hotel>()
            //    .Navigation(h => h.Manager)
            //    .AutoInclude();  // Auto-include Reservations
        }

        public DbSet<Entities.Customer> Customers { get; set; }
        public DbSet<Entities.CustomerReservation> CustomerReservations { get; set; }
        public DbSet<Entities.Manager> Managers { get; set; }
        public DbSet<Entities.Reservation> Reservations { get; set; }
        public DbSet<Entities.Hotel> Hotels { get; set; }
        public DbSet<Entities.Room> Rooms { get; set; }
        

    }
}
