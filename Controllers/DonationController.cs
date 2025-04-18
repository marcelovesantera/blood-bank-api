using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllDonations(string search)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetDonationById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateDonation()
        {
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDonation(int id)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDonation(int id)
        {
            return NoContent();
        }
    }
}
