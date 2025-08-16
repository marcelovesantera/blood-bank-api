using BloodBankAPI.InputModels;
using BloodBankAPI.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BloodBankAPI.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly BloodBankDbContext _dbContext;

        public AddressController(BloodBankDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Post(CreateAddressInputModel address)
        {
            return CreatedAtAction(nameof(Get), new { Id = 1 }, address);
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
        public IActionResult Put(int id, UpdateAddressInputModel address)
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
