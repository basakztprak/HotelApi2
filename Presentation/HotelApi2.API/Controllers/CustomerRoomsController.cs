using HotelApi2.Application.Services;
using HotelApi2.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerRoomsController : ControllerBase
    {
        readonly private ICustomerRoomService _customerRoomService;

        public CustomerRoomsController(ICustomerRoomService customerRoomService)
        {
            _customerRoomService = customerRoomService;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok("Merhaba");
        //}

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customerRooms = _customerRoomService.GetAll();
            return Ok(customerRooms);

        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customerRooms = await _customerRoomService.GetByIdAsync(id);
            return Ok(customerRooms);
        }

        [HttpPost]
        public async Task<ActionResult<CustomerRooms>> Post(CustomerRooms customerRoom)
        {
            var success = await _customerRoomService.AddAsync(customerRoom);
            return Ok(customerRoom);
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(CustomerRooms customerRoom)
        {

            bool response =  _customerRoomService.Update(customerRoom);
            return Ok(customerRoom);


        }

        //[HttpDelete]
        //public async Task<ActionResult> Delete(CustomerRooms customerRoom)
        //{
        //   bool response =  _customerRoomService.Remove(customerRoom);
        // return Ok(customerRoom);
        //}

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool response = await _customerRoomService.RemoveAsync(id);
            return Ok(response);
        }




    }
}
