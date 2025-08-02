using BloodBank.Domain.Entities;
using BloodBankAPI.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace BloodBankAPI.Controllers
{
    [Route("api/donation")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(CreateDonationInputModel donation)
        {
            return CreatedAtAction(nameof(Get), new { Id = 1 }, donation);
        }

        [HttpGet]
        public IActionResult GetAll(string search)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
