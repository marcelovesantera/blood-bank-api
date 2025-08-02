using BloodBankAPI.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace BloodBankAPI.Controllers
{
    [Route("api/donor")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(CreateDonorInputModel donor)
        {
            return CreatedAtAction(nameof(Get), new { Id = 1 }, donor);
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
