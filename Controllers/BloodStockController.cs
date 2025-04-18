using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/bloodstock")]
    public class BloodStockController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBloodStock()
        {
            return Ok();
        }

        [HttpGet("{bloodType}/{rhFactor}")]
        public IActionResult GetBloodStockByType(string bloodType, string rhFactor)
        {
            return Ok();
        }
    }
}
