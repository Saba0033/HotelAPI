using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HotelModels.Entities
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}