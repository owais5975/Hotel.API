using System.ComponentModel.DataAnnotations;

namespace Hotel.API.Models
{
    public class HotelModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Picture { get; set; } = string.Empty;
        [Required]
        public string Details { get; set; } = string.Empty;
        [Required]
        public int Rating { get; set; }
        [Required]
        public int City_Id { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public int Available_Rooms { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
