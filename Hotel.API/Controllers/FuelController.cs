using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        [HttpGet("GetFuelPrice")]
        public IActionResult FuelPrice()
        {
            return Ok(new { Status = true, Data = new { Petrol_Price = 233.91, Diesel_Price = 244.44 } });
        }
    }
}
