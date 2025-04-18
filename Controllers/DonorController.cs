using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public IActionResult CreateDonor()
        {
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDonor(int id)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDonor(int id)
        {
            return NoContent();
        }

        [HttpGet("{id}/donations")]
        public IActionResult GetDonationsHistoryByDonor(int id)
        {
            return Ok();
        }
    }
}
