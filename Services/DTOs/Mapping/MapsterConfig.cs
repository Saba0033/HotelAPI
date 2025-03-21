using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.CustomerDTOs;
using HotelAPI.Application.DTOs.HotelDTOs;
using HotelAPI.Application.DTOs.Identity;
using HotelAPI.Application.DTOs.ReservationDTOs;
using HotelAPI.Application.DTOs.RoomDTOs;
using HotelModels.Entities;
using Mapster;

namespace HotelAPI.Application.DTOs.Mapping
{
    public class MapsterConfig
    {
        public static void Configure()
        {

            //TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
            //TypeAdapterConfig.GlobalSettings.Default.IgnoreNullValues = true;
            //TypeAdapterConfig.GlobalSettings.Default.IgnoreNullValues(true);
            TypeAdapterConfig<Hotel, HotelForGetDTO>.NewConfig()
                .Map(dest => dest.Rooms, src => src.Rooms != null ? src.Rooms.Adapt<List<RoomForGetDTO>>(): new List<RoomForGetDTO>())
                .Map(dest => dest.Manager, src => src.Manager != null ? src.Manager.Adapt<ManagerForGettingDTO>() : new ManagerForGettingDTO());

            TypeAdapterConfig<HotelForCreateDTO, Hotel>.NewConfig();
            TypeAdapterConfig<HotelForUpdateDTO, Hotel>.NewConfig();
            TypeAdapterConfig<RoomForCreateDTO, Room>.NewConfig();
            TypeAdapterConfig<RoomForUpdateDTO, Room>.NewConfig();

     
            TypeAdapterConfig<Room, RoomForGetDTO>.NewConfig()
                .Map(dest => dest.Reservations, 
                    source => 
                        source.Reservations != null ? source.Reservations.Select(res  => res.Adapt<ReservationForGetDTO>()) : new List<ReservationForGetDTO>());
            
            TypeAdapterConfig<Customer, CustomerForGetDTO>.NewConfig()
                .Map(dest => dest.Reservations,
                    src => src.CustomerReservations != null ? src.CustomerReservations.Select(r
                        => r.Reservation.Adapt<ReservationForCustomerDTO>()) : new List<ReservationForCustomerDTO>());

            
            TypeAdapterConfig<Reservation, ReservationForGetDTO>.NewConfig().
                Map(dest => dest.Customers, source => source.Customers != null ? source.Customers.Select(c => c.Customer.Adapt<CustomerForReservationDTO>()) : new List<CustomerForReservationDTO>());

            TypeAdapterConfig<CustomerForCreateDTO, Customer>.NewConfig()
                .Map(dest => dest.UserName, source => source.Email)
                .Map(dest => dest.NormalizedEmail,src => src.Email.ToUpper());
        }
    }
}
