namespace Hotel.API.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Picture { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public int Rating { get; set; }
        public int City_Id { get; set; }
        public int Rooms { get; set; }
        public int Available_Rooms { get; set; } 
        public int Price { get; set; } 
    }
}
