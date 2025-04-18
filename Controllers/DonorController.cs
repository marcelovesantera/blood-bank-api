using BloodBank.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donors")]
    public class DonorController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllDonors(string search)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetDonorById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateDonor(CreateDonorInputModel model)
        {
            return CreatedAtAction(nameof(GetDonorById), new { id = 1 }, model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDonor(int id, UpdateDonorInputModel model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDonor(int id)
        {
            return NoContent();
        }

        [HttpGet("{id}/donations")]
        public IActionResult GetDonationsByDonorId(int id)
        {
            return Ok();
        }
    }
}
