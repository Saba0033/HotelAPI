using Microsoft.EntityFrameworkCore;
using HotelModels.Entities;

namespace HotelRepository.Data
{
    public static class EFHelper
    {
        public static void ConfigureEntities(this ModelBuilder modelBuilder)
        {
            ConfigureCustomers(modelBuilder);
            ConfigureCustomerReservations(modelBuilder);
            ConfigureHotels(modelBuilder);
            ConfigureManagers(modelBuilder);
            ConfigureReservations(modelBuilder);
            ConfigureRooms(modelBuilder);
        }

        public static void SeedData(this ModelBuilder modelBuilder)
        {
            SeedHotels(modelBuilder);
            SeedRooms(modelBuilder);
            SeedManagers(modelBuilder);
            SeedCustomers(modelBuilder);
            SeedReservations(modelBuilder);
            SeedCutomerReservations(modelBuilder);
        }

        private static void ConfigureCustomers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                
                entity.HasKey(c => c.CustomerId);

                entity.Property(c => c.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(c => c.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(c => c.IdentityNumber)
                    .IsRequired()
                    .HasColumnType("char(11)")
                    .IsUnicode(false);

                //entity.HasCheckConstraint("FixedLenght(11)", "Len[IdentityNumber] = 11");
                entity.HasIndex(c => c.IdentityNumber)
                    .IsUnique();

                entity.Property(c => c.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(c => c.PhoneNumber)
                    .HasMaxLength(20).IsUnicode(false);

                entity.HasMany(c => c.Reservations);
            });
        }

        private static void ConfigureCustomerReservations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerReservation>(entity =>
            {
                entity.HasKey(cr => cr.Id);

                entity.HasOne(cr => cr.Customer)
                    .WithMany(c => c.Reservations)
                    .HasForeignKey(cr => cr.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(cr => cr.Reservation)
                    .WithMany(r => r.Customers)
                    .HasForeignKey(cr => cr.ReservationId)
                    .OnDelete(DeleteBehavior.Cascade);

                

            });
        }

        private static void ConfigureHotels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(h => h.HotelId);
                entity.HasIndex(h => h.Name).IsUnique();
                entity.Property(h => h.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(h => h.Rating)
                    .IsRequired()
                    .HasConversion<int>()
                    .HasMaxLength(5);

                entity.Property(h => h.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(h => h.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(h => h.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(h => h.Manager)
                    .WithOne(m => m.Hotel)
                    .HasForeignKey<Manager>(m => m.HotelId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(h => h.Rooms)
                    .WithOne(r => r.Hotel)
                    .HasForeignKey(r => r.HotelId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }

        private static void ConfigureManagers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasKey(m => m.ManagerId);

                entity.Property(m => m.FirsName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(m => m.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                
                entity.Property(m => m.IdentityNumber)
                    .IsRequired()
                    .HasColumnType("char(11)")
                    .IsUnicode(false);

                //entity.HasCheckConstraint("FixedLenght(11)", "Len[IdentityNumber] = 11");
                entity.HasIndex(m => m.IdentityNumber)
                    .IsUnique();

                entity.Property(m => m.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(m => m.PhoneNumber)
                    .HasMaxLength(20).IsUnicode(false);

                entity.HasOne(m => m.Hotel)
                    .WithOne(h => h.Manager)
                    .HasForeignKey<Manager>(m => m.HotelId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }

        private static void ConfigureReservations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(r => r.ReservationId);

                entity.Property(r => r.CheckIn)
                    .IsRequired();

                entity.Property(r => r.CheckOut)
                    .IsRequired();

                entity.HasOne(r => r.Room)
                    .WithMany(room => room.Reservations)
                    .HasForeignKey(r => r.RoomId);
            });
        }

        private static void ConfigureRooms(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(r => r.RoomId);

                entity.Property(r => r.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(r => r.Price)
                    .HasColumnType("money")
                    .IsRequired();

                entity.HasOne(r => r.Hotel)
                    .WithMany(h => h.Rooms)
                    .HasForeignKey(r => r.HotelId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(r => r.Reservations);
            });
        }

        private static void SeedHotels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = HotelGuid1,
                    Name = "Golden Palace",
                    Rating = Hotel.HotelRating.FiveStars,
                    Country = "France",
                    City = "Paris",
                    Address = "Paris street 1"
                },
                new Hotel
                {
                    HotelId = HotelGuid2,
                    Name = "Hotel Aura",
                    Rating = Hotel.HotelRating.FourStars,
                    Country = "Italy",
                    City = "Rome",
                    Address = "Rome street 2"
                },
                new Hotel
                {
                    HotelId = HotelGuid3,
                    Name = "Hotel Mogzauri",
                    Rating = Hotel.HotelRating.TwoStars,
                    Country = "Georgia",
                    City = "Tbilisi",
                    Address = "Tbilisi street 3"
                }
            );
        }

        private static void SeedRooms(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = RoomGuid1,
                    Name = "Room 1",
                    Price = 1000,
                    HotelId = HotelGuid1
                },
                new Room
                {
                    RoomId = RoomGuid2,
                    Name = "Room 2",
                    Price = 1500,
                    HotelId = HotelGuid1
                },
                new Room
                {
                    RoomId = RoomGuid3,
                    Name = "Room 3",
                    Price = 500,
                    HotelId = HotelGuid1
                },
                new Room
                {
                    RoomId = RoomGuid4,
                    Name = "Room 4",
                    Price = 2000,
                    HotelId = HotelGuid2
                },
                new Room
                {
                    RoomId = RoomGuid5,
                    Name = "Room 5",
                    Price = 2500,
                    HotelId = HotelGuid2
                },
                new Room
                {
                    RoomId = RoomGuid6,
                    Name = "Room 6",
                    Price = 1000,
                    HotelId = HotelGuid2
                },
                new Room
                {
                    RoomId = RoomGuid7,
                    Name = "Room 7",
                    Price = 500,
                    HotelId = HotelGuid3
                },
                new Room
                {
                    RoomId = RoomGuid8,
                    Name = "Room 8",
                    Price = 1000,
                    HotelId = HotelGuid3
                },
                new Room
                {
                    RoomId = RoomGuid9,
                    Name = "Room 9",
                    Price = 1500,
                    HotelId = HotelGuid3
                },
                new Room
                {
                    RoomId = RoomGuid10,
                    Name = "Room 10",
                    Price = 2000,
                    HotelId = HotelGuid3
                },
                new Room
                {
                    RoomId = RoomGuid11,
                    Name = "Room 11",
                    Price = 2500,
                    HotelId = HotelGuid3
                },
                new Room
                {
                    RoomId = RoomGuid12,
                    Name = "Room 12",
                    Price = 3000,
                    HotelId = HotelGuid3
                }

            );
        }

        private static void SeedManagers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manager>().HasData(
                new Manager
                {
                    ManagerId = ManagerGuid1,
                    FirsName = "John",
                    LastName = "Doe",
                    IdentityNumber = "12345678901",
                    Email = "GoldenPalaceManager@gmail.com",
                    PhoneNumber = "123456789",
                    HotelId = HotelGuid1
                },
                new Manager
                {
                    ManagerId = ManagerGuid2,
                    FirsName = "Jane",
                    LastName = "Chan",
                    IdentityNumber = "12345678902",
                    Email = "AuraManager@gmail.com",
                    PhoneNumber = "123456789",
                    HotelId = HotelGuid2
                },
                new Manager
                {
                    ManagerId = ManagerGuid3,
                    FirsName = "Jack",
                    LastName = "Bond",
                    IdentityNumber = "12345678903",
                    Email = "MogzauriManager@gmail.com",
                    PhoneNumber = "123456789",
                    HotelId = HotelGuid3
                }
                );
        }

        private static void SeedCustomers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = CustomerGuid1,
                    FirstName = "Saba",
                    LastName = "Ekhvaia",
                    IdentityNumber = "12345678901",
                    Email = "sekhv23@freeuni.edu.ge",
                    PhoneNumber = "123456789"
                },
                new Customer
                {
                    CustomerId = CustomerGuid2,
                    FirstName = "Nika",
                    LastName = "Kavtaradze",
                    IdentityNumber = "12345678902",
                    Email = "Nika123@gmail.com",
                    PhoneNumber = "123456789"
                },
                new Customer
                {
                    CustomerId = CustomerGuid3,
                    FirstName = "Giorgi",
                    LastName = "Kavtaradze",
                    IdentityNumber = "12345678903",
                    Email = "Gio@gmail.com",
                    PhoneNumber = "123456789"
                },
                new Customer
                {
                    CustomerId = CustomerGuid4,
                    FirstName = "Nino",
                    LastName = "Kavtaradze",
                    IdentityNumber = "12345678904",
                    Email = "Nino@gmail.com",
                    PhoneNumber = "123456789"

                },
                new Customer
                {
                    CustomerId = CustomerGuid5,
                    FirstName = "Ana",
                    LastName = "Kavtaradze",
                    IdentityNumber = "12345678905",
                    Email = "Ana@gmail.com",
                    PhoneNumber = "123456789"
                }
                );
        }

        private static void SeedReservations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    ReservationId = ReservationGuid1,
                    CheckIn = new DateTime(2021, 12, 1),
                    CheckOut = new DateTime(2021, 12, 5),
                    RoomId = RoomGuid1
                },
                new Reservation
                {
                    ReservationId = ReservationGuid2,
                    CheckIn = new DateTime(2024, 2, 1),
                    CheckOut = new DateTime(2025, 12, 7),
                    RoomId = RoomGuid1
                },
                new Reservation
                {
                    ReservationId = ReservationGuid3,
                    CheckIn = new DateTime(2021, 11, 1),
                    CheckOut = new DateTime(2022, 12, 5),
                    RoomId = RoomGuid3
                },
                new Reservation
                {
                    ReservationId = ReservationGuid4,
                    CheckIn = new DateTime(2021, 11, 5),
                    CheckOut = new DateTime(2021, 11, 12),
                    RoomId = RoomGuid4
                },
                new Reservation
                {
                    ReservationId = ReservationGuid5,
                    CheckIn = new DateTime(2023, 12, 14),
                    CheckOut = new DateTime(2023, 12, 15),
                    RoomId = RoomGuid10
                },
                new Reservation
                {
                    ReservationId = ReservationGuid6,
                    CheckIn = new DateTime(2021, 12, 1),
                    CheckOut = new DateTime(2021, 12, 5),
                    RoomId = RoomGuid12
                },
                new Reservation
                {
                    ReservationId = ReservationGuid7,
                    CheckIn = new DateTime(2021, 12, 1),
                    CheckOut = new DateTime(2021, 12, 5),
                    RoomId = RoomGuid7
                },
                new Reservation
                {
                    ReservationId = ReservationGuid8,
                    CheckIn = new DateTime(2021, 12, 1),
                    CheckOut = new DateTime(2021, 12, 5),
                    RoomId = RoomGuid8
                }
                );
        }

        private static void SeedCutomerReservations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerReservation>().HasData(
                new CustomerReservation
                {
                    Id = CustomerReservationGuid1,
                    CustomerId = CustomerGuid1,
                    ReservationId = ReservationGuid1
                },
                new CustomerReservation
                {
                    Id = CustomerReservationGuid2,
                    CustomerId = CustomerGuid1,
                    ReservationId = ReservationGuid2
                },
                new CustomerReservation
                {
                    Id = CustomerReservationGuid3,
                    CustomerId = CustomerGuid3,
                    ReservationId = ReservationGuid3
                },
                new CustomerReservation
                {
                    Id = CustomerReservationGuid4,
                    CustomerId = CustomerGuid4,
                    ReservationId = ReservationGuid4
                },
                new CustomerReservation
                {
                    Id = CustomerReservationGuid5,
                    CustomerId = CustomerGuid5,
                    ReservationId = ReservationGuid5
                },
                new CustomerReservation
                {
                    Id = CustomerReservationGuid6,
                    CustomerId = CustomerGuid1,
                    ReservationId = ReservationGuid6
                },
                new CustomerReservation
                {
                    Id = CustomerReservationGuid7,
                    CustomerId = CustomerGuid2,
                    ReservationId = ReservationGuid7
                },
                new CustomerReservation
                {
                    Id = CustomerReservationGuid8,
                    CustomerId = CustomerGuid3,
                    ReservationId = ReservationGuid8
                }
            );
        }


        private static readonly Guid HotelGuid1 = new Guid("11111111-1111-1111-1111-111111111111");
        private static readonly Guid HotelGuid2 = new Guid("22222222-2222-2222-2222-222222222222");
        private static readonly Guid HotelGuid3 = new Guid("33333333-3333-3333-3333-333333333333");
        private static readonly Guid ManagerGuid1 = new Guid("44444444-4444-4444-4444-444444444444");
        private static readonly Guid ManagerGuid2 = new Guid("55555555-5555-5555-5555-555555555555");
        private static readonly Guid ManagerGuid3 = new Guid("66666666-6666-6666-6666-666666666666");
        private static readonly Guid RoomGuid1 = new Guid("77777777-7777-7777-7777-777777777777");
        private static readonly Guid RoomGuid2 = new Guid("88888888-8888-8888-8888-888888888888");
        private static readonly Guid RoomGuid3 = new Guid("99999999-9999-9999-9999-999999999999");
        private static readonly Guid RoomGuid4 = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
        private static readonly Guid RoomGuid5 = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
        private static readonly Guid RoomGuid6 = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc");
        private static readonly Guid RoomGuid7 = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd");
        private static readonly Guid RoomGuid8 = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");
        private static readonly Guid RoomGuid9 = new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff");
        private static readonly Guid RoomGuid10 = new Guid("12345678-1234-1234-1234-1234567890ab");
        private static readonly Guid RoomGuid11 = new Guid("23456789-2345-2345-2345-234567890abc");
        private static readonly Guid RoomGuid12 = new Guid("34567890-3456-3456-3456-34567890abcd");
        private static readonly Guid CustomerGuid1 = new Guid("45678901-4567-4567-4567-456789012345");
        private static readonly Guid CustomerGuid2 = new Guid("56789012-5678-5678-5678-567890123456");
        private static readonly Guid CustomerGuid3 = new Guid("67890123-6789-6789-6789-678901234567");
        private static readonly Guid CustomerGuid4 = new Guid("78901234-7890-7890-7890-789012345678");
        private static readonly Guid CustomerGuid5 = new Guid("89012345-8901-8901-8901-890123456789");
        private static readonly Guid ReservationGuid1 = new Guid("90123456-9012-9012-9012-901234567890");
        private static readonly Guid ReservationGuid2 = new Guid("01234567-0123-0123-0123-012345678901");
        private static readonly Guid ReservationGuid3 = new Guid("12345678-2345-2345-2345-234567890123");
        private static readonly Guid ReservationGuid4 = new Guid("23456789-3456-3456-3456-345678901234");
        private static readonly Guid ReservationGuid5 = new Guid("34567890-4567-4567-4567-456789012345");
        private static readonly Guid ReservationGuid6 = new Guid("45678901-5678-5678-5678-567890123456");
        private static readonly Guid ReservationGuid7 = new Guid("56789012-6789-6789-6789-678901234567");
        private static readonly Guid ReservationGuid8 = new Guid("67890123-7890-7890-7890-789012345678");
        private static readonly Guid CustomerReservationGuid1 = new Guid("78901234-8901-8901-8901-890123456789");
        private static readonly Guid CustomerReservationGuid2 = new Guid("89012345-9012-9012-9012-901234567890");
        private static readonly Guid CustomerReservationGuid3 = new Guid("90123456-0123-0123-0123-012345678901");
        private static readonly Guid CustomerReservationGuid4 = new Guid("01234567-1234-1234-1234-123456789012");
        private static readonly Guid CustomerReservationGuid5 = new Guid("12345678-2345-2345-2345-234567890123");
        private static readonly Guid CustomerReservationGuid6 = new Guid("23456789-3456-3456-3456-345678901234");
        private static readonly Guid CustomerReservationGuid7 = new Guid("34567890-4567-4567-4567-456789012345");
        private static readonly Guid CustomerReservationGuid8 = new Guid("45678901-5678-5678-5678-567890123456");

    }
}
