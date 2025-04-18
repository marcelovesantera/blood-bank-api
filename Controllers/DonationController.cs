using BloodBank.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donations")]
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
        public IActionResult CreateDonation(CreateDonationInputModel model)
        {
            return CreatedAtAction(nameof(GetDonationById), new { id = 1 }, model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDonation(int id, UpdateDonationInputModel model)
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
