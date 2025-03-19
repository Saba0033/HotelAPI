using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Domain.Entities;
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
            modelBuilder.Entity<Customer>(e => e.ToTable("Users/Customers"));
            modelBuilder.Entity<IdentityRole<Guid>>(e => e.ToTable("Roles"));
            modelBuilder.Entity<IdentityUserRole<Guid>>(e => e.ToTable("UserRoles"));
            //modelBuilder.Ignore<IdentityRoleClaim<Guid>>();
            //modelBuilder.Ignore<IdentityUserClaim<Guid>>();
            //modelBuilder.Ignore<IdentityUserLogin<Guid>>();
            //modelBuilder.Ignore<IdentityUserToken<Guid>>();
               
            modelBuilder.Entity<IdentityRole<Guid>>()
                .HasKey(r => r.Id);  // Ensure the role's Id is set to Guid



            modelBuilder.Entity<CustomerReservation>()
                .Navigation(h => h.Reservation)
                .AutoInclude();

            modelBuilder.Entity<CustomerReservation>()
                .Navigation(h => h.Customer)
                .AutoInclude();  // Auto-include Reservations
        }

        public DbSet<Entities.Customer> Customers { get; set; }
        public DbSet<Entities.CustomerReservation> CustomerReservations { get; set; }
        public DbSet<Entities.Manager> Managers { get; set; }
        public DbSet<Entities.Reservation> Reservations { get; set; }
        public DbSet<Entities.Hotel> Hotels { get; set; }
        public DbSet<Entities.Room> Rooms { get; set; }
        //public DbSet<IdentityRole<Guid>> UserRoles { get; set; }

    }
}
