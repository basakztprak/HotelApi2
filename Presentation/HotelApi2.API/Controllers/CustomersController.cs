using HotelApi2.Application.Services;
using HotelApi2.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        readonly private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok("Merhaba");
        //}

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var customer = _customerService.GetAll();
            return Ok(customer);

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<Customers>> Post(Customers customer)
        {
            var success = await _customerService.AddAsync(customer);
            return Ok(customer);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Customers customer)
        {

            bool response = _customerService.Update(customer);
            return Ok(customer);


        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool response = await _customerService.RemoveAsync(id);
            return Ok(response);
        }

    }

}
    
