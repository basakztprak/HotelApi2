using HotelApi2Mongo.Application.Entities;
using HotelApi2Mongo.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi2Mongo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customersService;

        public CustomersController(ICustomerService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAll()
        {
            return await _customersService.GetAllAsync();
        }

        [HttpGet("{id:length(24)}", Name = "GetCustomer")]
        public async Task<ActionResult<Customer>> GetById(string id)
        {
            var customer = await _customersService.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Create(Customer customer)
        {
            await _customersService.CreateAsync(customer);

            return CreatedAtRoute("GetCustomer", new { id = customer.Id.ToString() }, customer);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> UpdateCustomer(string id, Customer customerIn)
        {
            var customer = _customersService.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            await _customersService.UpdateAsync(id, customerIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeleteCustomer(string id)
        {
            var customer = _customersService.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            await _customersService.DeleteAsync(id);

            return NoContent();
        }
    }
}
