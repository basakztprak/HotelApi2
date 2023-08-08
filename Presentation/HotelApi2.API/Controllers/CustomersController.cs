using AutoMapper;
using HotelApi2.Application.Models;
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
        public async Task<ActionResult<CustomerDto>> Post(CustomerDto customerDto)
        {
            var success = await _customerService.AddAsync(customerDto);
            return Ok(customerDto);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(CustomerDto customerDto)
        {

            bool response = _customerService.Update(customerDto);
            return Ok(customerDto);


        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool response = await _customerService.RemoveAsync(id);
            return Ok(response);
        }


        //[HttpPost]
        //public async Task<IActionResult> Post(CustomerDto customerDto)
        //{
        //    var customer = _mapper.Map<Customers>(customerDto);
        //    await _customerService.AddAsync(customer);
        //    return Ok(customerDto);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(CustomerDto customerDto)
        //{
        //    var customer = _mapper.Map<Customers>(customerDto);
        //    _customerService.Update(customer);
        //    return Ok(customerDto);
        //}


    }

}
    
