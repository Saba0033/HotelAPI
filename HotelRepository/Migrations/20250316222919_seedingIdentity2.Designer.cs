﻿// <auto-generated />
using System;
using HotelModels.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelRepository.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20250316222919_seedingIdentity2")]
    partial class seedingIdentity2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelModels.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("char(11)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Customers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("45678901-4567-4567-4567-456789012345"),
                            Email = "sekhv23@freeuni.edu.ge",
                            EmailConfirmed = false,
                            FirstName = "Saba",
                            IdentityNumber = "12345678901",
                            LastName = "Ekhvaia",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("56789012-5678-5678-5678-567890123456"),
                            Email = "Nika123@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nika",
                            IdentityNumber = "12345678902",
                            LastName = "Kavtaradze",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("67890123-6789-6789-6789-678901234567"),
                            Email = "Gio@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Giorgi",
                            IdentityNumber = "12345678903",
                            LastName = "Kavtaradze",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("78901234-7890-7890-7890-789012345678"),
                            Email = "Nino@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nino",
                            IdentityNumber = "12345678904",
                            LastName = "Kavtaradze",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("89012345-8901-8901-8901-890123456789"),
                            Email = "Ana@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ana",
                            IdentityNumber = "12345678905",
                            LastName = "Kavtaradze",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("44444444-4444-4444-4444-444444444444"),
                            Email = "GoldenPalaceManager@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            IdentityNumber = "12345678999",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("55555555-5555-5555-5555-555555555555"),
                            Email = "AuraManager@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Jane",
                            IdentityNumber = "92345678999",
                            LastName = "Chan",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = new Guid("66666666-6666-6666-6666-666666666666"),
                            Email = "MogzauriManager@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Jack",
                            IdentityNumber = "99945678903",
                            LastName = "Bond",
                            PhoneNumber = "123456789"
                        });
                });

            modelBuilder.Entity("HotelModels.Entities.CustomerReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ReservationId");

                    b.ToTable("CustomerReservations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("78901234-8901-8901-8901-890123456789"),
                            CustomerId = new Guid("45678901-4567-4567-4567-456789012345"),
                            ReservationId = new Guid("90123456-9012-9012-9012-901234567890")
                        },
                        new
                        {
                            Id = new Guid("89012345-9012-9012-9012-901234567890"),
                            CustomerId = new Guid("45678901-4567-4567-4567-456789012345"),
                            ReservationId = new Guid("01234567-0123-0123-0123-012345678901")
                        },
                        new
                        {
                            Id = new Guid("90123456-0123-0123-0123-012345678901"),
                            CustomerId = new Guid("67890123-6789-6789-6789-678901234567"),
                            ReservationId = new Guid("12345678-2345-2345-2345-234567890123")
                        },
                        new
                        {
                            Id = new Guid("01234567-1234-1234-1234-123456789012"),
                            CustomerId = new Guid("78901234-7890-7890-7890-789012345678"),
                            ReservationId = new Guid("23456789-3456-3456-3456-345678901234")
                        },
                        new
                        {
                            Id = new Guid("12345678-2345-2345-2345-234567890123"),
                            CustomerId = new Guid("89012345-8901-8901-8901-890123456789"),
                            ReservationId = new Guid("34567890-4567-4567-4567-456789012345")
                        },
                        new
                        {
                            Id = new Guid("23456789-3456-3456-3456-345678901234"),
                            CustomerId = new Guid("45678901-4567-4567-4567-456789012345"),
                            ReservationId = new Guid("45678901-5678-5678-5678-567890123456")
                        },
                        new
                        {
                            Id = new Guid("34567890-4567-4567-4567-456789012345"),
                            CustomerId = new Guid("56789012-5678-5678-5678-567890123456"),
                            ReservationId = new Guid("56789012-6789-6789-6789-678901234567")
                        },
                        new
                        {
                            Id = new Guid("45678901-5678-5678-5678-567890123456"),
                            CustomerId = new Guid("67890123-6789-6789-6789-678901234567"),
                            ReservationId = new Guid("67890123-7890-7890-7890-789012345678")
                        });
                });

            modelBuilder.Entity("HotelModels.Entities.Hotel", b =>
                {
                    b.Property<Guid>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Rating")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            HotelId = new Guid("11111111-1111-1111-1111-111111111111"),
                            Address = "Paris street 1",
                            City = "Paris",
                            Country = "France",
                            Name = "Golden Palace",
                            Rating = 5
                        },
                        new
                        {
                            HotelId = new Guid("22222222-2222-2222-2222-222222222222"),
                            Address = "Rome street 2",
                            City = "Rome",
                            Country = "Italy",
                            Name = "Hotel Aura",
                            Rating = 4
                        },
                        new
                        {
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            Address = "Tbilisi street 3",
                            City = "Tbilisi",
                            Country = "Georgia",
                            Name = "Hotel Mogzauri",
                            Rating = 2
                        });
                });

            modelBuilder.Entity("HotelModels.Entities.Manager", b =>
                {
                    b.Property<Guid>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("char(11)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ManagerId");

                    b.HasIndex("HotelId")
                        .IsUnique()
                        .HasFilter("[HotelId] IS NOT NULL");

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            ManagerId = new Guid("44444444-4444-4444-4444-444444444444"),
                            Email = "GoldenPalaceManager@gmail.com",
                            FirsName = "John",
                            HotelId = new Guid("11111111-1111-1111-1111-111111111111"),
                            IdentityNumber = "12345678999",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            ManagerId = new Guid("55555555-5555-5555-5555-555555555555"),
                            Email = "AuraManager@gmail.com",
                            FirsName = "Jane",
                            HotelId = new Guid("22222222-2222-2222-2222-222222222222"),
                            IdentityNumber = "92345678999",
                            LastName = "Chan",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            ManagerId = new Guid("66666666-6666-6666-6666-666666666666"),
                            Email = "MogzauriManager@gmail.com",
                            FirsName = "Jack",
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            IdentityNumber = "99945678903",
                            LastName = "Bond",
                            PhoneNumber = "123456789"
                        });
                });

            modelBuilder.Entity("HotelModels.Entities.Reservation", b =>
                {
                    b.Property<Guid>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReservationId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = new Guid("90123456-9012-9012-9012-901234567890"),
                            CheckIn = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("77777777-7777-7777-7777-777777777777")
                        },
                        new
                        {
                            ReservationId = new Guid("01234567-0123-0123-0123-012345678901"),
                            CheckIn = new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2025, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("77777777-7777-7777-7777-777777777777")
                        },
                        new
                        {
                            ReservationId = new Guid("12345678-2345-2345-2345-234567890123"),
                            CheckIn = new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("99999999-9999-9999-9999-999999999999")
                        },
                        new
                        {
                            ReservationId = new Guid("23456789-3456-3456-3456-345678901234"),
                            CheckIn = new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa")
                        },
                        new
                        {
                            ReservationId = new Guid("34567890-4567-4567-4567-456789012345"),
                            CheckIn = new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("12345678-1234-1234-1234-1234567890ab")
                        },
                        new
                        {
                            ReservationId = new Guid("45678901-5678-5678-5678-567890123456"),
                            CheckIn = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("34567890-3456-3456-3456-34567890abcd")
                        },
                        new
                        {
                            ReservationId = new Guid("56789012-6789-6789-6789-678901234567"),
                            CheckIn = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd")
                        },
                        new
                        {
                            ReservationId = new Guid("67890123-7890-7890-7890-789012345678"),
                            CheckIn = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee")
                        });
                });

            modelBuilder.Entity("HotelModels.Entities.Room", b =>
                {
                    b.Property<Guid>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("RoomId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = new Guid("77777777-7777-7777-7777-777777777777"),
                            HotelId = new Guid("11111111-1111-1111-1111-111111111111"),
                            Name = "Room 1",
                            Price = 1000m
                        },
                        new
                        {
                            RoomId = new Guid("88888888-8888-8888-8888-888888888888"),
                            HotelId = new Guid("11111111-1111-1111-1111-111111111111"),
                            Name = "Room 2",
                            Price = 1500m
                        },
                        new
                        {
                            RoomId = new Guid("99999999-9999-9999-9999-999999999999"),
                            HotelId = new Guid("11111111-1111-1111-1111-111111111111"),
                            Name = "Room 3",
                            Price = 500m
                        },
                        new
                        {
                            RoomId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                            HotelId = new Guid("22222222-2222-2222-2222-222222222222"),
                            Name = "Room 4",
                            Price = 2000m
                        },
                        new
                        {
                            RoomId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                            HotelId = new Guid("22222222-2222-2222-2222-222222222222"),
                            Name = "Room 5",
                            Price = 2500m
                        },
                        new
                        {
                            RoomId = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                            HotelId = new Guid("22222222-2222-2222-2222-222222222222"),
                            Name = "Room 6",
                            Price = 1000m
                        },
                        new
                        {
                            RoomId = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            Name = "Room 7",
                            Price = 500m
                        },
                        new
                        {
                            RoomId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            Name = "Room 8",
                            Price = 1000m
                        },
                        new
                        {
                            RoomId = new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            Name = "Room 9",
                            Price = 1500m
                        },
                        new
                        {
                            RoomId = new Guid("12345678-1234-1234-1234-1234567890ab"),
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            Name = "Room 10",
                            Price = 2000m
                        },
                        new
                        {
                            RoomId = new Guid("23456789-2345-2345-2345-234567890abc"),
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            Name = "Room 11",
                            Price = 2500m
                        },
                        new
                        {
                            RoomId = new Guid("34567890-3456-3456-3456-34567890abcd"),
                            HotelId = new Guid("33333333-3333-3333-3333-333333333333"),
                            Name = "Room 12",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("56789012-6789-6789-6789-678901234567"),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("67890123-7890-7890-7890-789012345678"),
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = new Guid("78901234-8901-8901-8901-890123456789"),
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("44444444-4444-4444-4444-444444444444"),
                            RoleId = new Guid("67890123-7890-7890-7890-789012345678")
                        },
                        new
                        {
                            UserId = new Guid("55555555-5555-5555-5555-555555555555"),
                            RoleId = new Guid("56789012-6789-6789-6789-678901234567")
                        },
                        new
                        {
                            UserId = new Guid("66666666-6666-6666-6666-666666666666"),
                            RoleId = new Guid("67890123-7890-7890-7890-789012345678")
                        },
                        new
                        {
                            UserId = new Guid("45678901-4567-4567-4567-456789012345"),
                            RoleId = new Guid("78901234-8901-8901-8901-890123456789")
                        },
                        new
                        {
                            UserId = new Guid("56789012-5678-5678-5678-567890123456"),
                            RoleId = new Guid("78901234-8901-8901-8901-890123456789")
                        },
                        new
                        {
                            UserId = new Guid("67890123-6789-6789-6789-678901234567"),
                            RoleId = new Guid("78901234-8901-8901-8901-890123456789")
                        },
                        new
                        {
                            UserId = new Guid("78901234-7890-7890-7890-789012345678"),
                            RoleId = new Guid("78901234-8901-8901-8901-890123456789")
                        },
                        new
                        {
                            UserId = new Guid("89012345-8901-8901-8901-890123456789"),
                            RoleId = new Guid("78901234-8901-8901-8901-890123456789")
                        });
                });

            modelBuilder.Entity("HotelModels.Entities.CustomerReservation", b =>
                {
                    b.HasOne("HotelModels.Entities.Customer", "Customer")
                        .WithMany("CustomerReservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HotelModels.Entities.Reservation", "Reservation")
                        .WithMany("Customers")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Customer");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("HotelModels.Entities.Manager", b =>
                {
                    b.HasOne("HotelModels.Entities.Hotel", "Hotel")
                        .WithOne("Manager")
                        .HasForeignKey("HotelModels.Entities.Manager", "HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("HotelModels.Entities.Reservation", b =>
                {
                    b.HasOne("HotelModels.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelModels.Entities.Room", b =>
                {
                    b.HasOne("HotelModels.Entities.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelModels.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelModels.Entities.Customer", b =>
                {
                    b.Navigation("CustomerReservations");
                });

            modelBuilder.Entity("HotelModels.Entities.Hotel", b =>
                {
                    b.Navigation("Manager");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("HotelModels.Entities.Reservation", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("HotelModels.Entities.Room", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
