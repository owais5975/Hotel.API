using Hotel.API.Entities;
using Hotel.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private ApplicationDBContext _context;
        public HotelController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("GetHotel")]
        public IActionResult GetHotel()
        {
            var data = _context.Hotels.Where(x => x.Id == 7).ToList();
            _context.Hotels.RemoveRange(data);
            _context.SaveChanges();
            return Ok(new {Status = true, Message = _context.Hotels.ToList()});
        }

        [HttpPost("AddHotel")]
        public IActionResult AddHotel([FromBody]HotelModel hotelModel)
        {
            try
            {
                Hotel.API.Entities.Hotel hotel = new Hotel.API.Entities.Hotel();
                hotel.Name = hotelModel.Name;
                hotel.Details = hotelModel.Details;
                hotel.Picture = hotelModel.Picture;
                hotel.Rating = hotelModel.Rating;
                hotel.Price = hotelModel.Price;
                hotel.Rooms = hotelModel.Rooms;
                hotel.Available_Rooms = hotelModel.Available_Rooms;
                hotel.City_Id = hotelModel.City_Id;
                _context.Hotels.Add(hotel);
                _context.SaveChanges();

                return Ok(new { Status = true, Message = "Hotel added successfully." });
            }
            catch (Exception)
            {
                return BadRequest(new { Status = false, Message = "Hotel not added." });
            }
        }


    }
}
