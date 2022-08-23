using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        public IActionResult FuelPrice()
        {
            return Ok(new { Status = true, Data = new { Petrol_Price = 233.91, Diesel_Price = 244.44 } });
        }
    }
}
