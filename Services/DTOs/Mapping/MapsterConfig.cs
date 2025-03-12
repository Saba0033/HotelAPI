using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.DTOs.HotelDTOs;
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
            TypeAdapterConfig<Hotel, HotelForGetDTO>.NewConfig()
                .Map(dest => dest.Rooms, src => src.Rooms.Adapt<List<RoomForGetDTO>>())
                .Map(dest => dest.Manager, src => src.Manager.Adapt<ManagerForGettingDTO>());

            TypeAdapterConfig<HotelForCreateDTO, Hotel>.NewConfig();
            TypeAdapterConfig<HotelForUpdateDTO, Hotel>.NewConfig();
            TypeAdapterConfig<RoomForCreateDTO, Room>.NewConfig();
            TypeAdapterConfig<RoomForUpdateDTO, Room>.NewConfig();
            TypeAdapterConfig<Room, RoomForGetDTO>.NewConfig()
                .Map(dest => dest.Reservations, source => source.Reservations.Adapt<ReservationForGetDTO>());
            TypeAdapterConfig<Reservation, ReservationForGetDTO>.NewConfig();

        }
    }
}
