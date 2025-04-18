using BloodBank.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("api/donations")]
    public class DonationController : ControllerBase
    {
        private readonly BloodDonationQuantityConfig _bloodDonationQuantityConfig;

        public DonationController(IOptions<BloodDonationQuantityConfig> bloodDonationQuantityConfig)
        {
            _bloodDonationQuantityConfig = bloodDonationQuantityConfig.Value;
        }

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
            if (model.QuantityInMilliliters < _bloodDonationQuantityConfig.MinAllowed || model.QuantityInMilliliters > _bloodDonationQuantityConfig.MaxAllowed)
            {
                return BadRequest($"Donation quantity must be between {_bloodDonationQuantityConfig.MinAllowed}ml and {_bloodDonationQuantityConfig.MaxAllowed}ml.");
            }

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
