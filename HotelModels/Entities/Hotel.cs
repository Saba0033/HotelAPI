using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelModels.Entities
{
    public class Hotel
    {
        public Guid HotelId { get; set; }
        public string Name { get; set; }
        public HotelRating Rating { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Manager? Manager { get; set; }
        public List<Room>? Rooms { get; set; }



        public enum HotelRating
        {
            OneStar = 1,
            TwoStars = 2,
            ThreeStars = 3,
            FourStars = 4,
            FiveStars = 5
        }
    }
}