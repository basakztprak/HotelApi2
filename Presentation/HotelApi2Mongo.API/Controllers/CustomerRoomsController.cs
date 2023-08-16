using HotelApi2Mongo.Application.Entities;
using HotelApi2Mongo.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi2Mongo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerRoomsController : ControllerBase
    {
        private readonly ICustomerRoomService _customerRoomsService;

        public CustomerRoomsController(ICustomerRoomService customerRoomsService)
        {
            _customerRoomsService = customerRoomsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerRoom>>> GetAll()
        {
            return await _customerRoomsService.GetAllAsync();
        }

        [HttpGet("{id:length(24)}", Name = "GetCustomerRoom")]
        public async Task<ActionResult<CustomerRoom>> GetById(string id)
        {
            var customerRoom = await _customerRoomsService.GetByIdAsync(id);

            if (customerRoom == null)
            {
                return NotFound();
            }

            return customerRoom;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerRoom>> Create(CustomerRoom customerRoom)
        {
            await _customerRoomsService.CreateAsync(customerRoom);

            return CreatedAtRoute("GetCustomerRoom", new { id = customerRoom.Id.ToString() }, customerRoom);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, CustomerRoom customerRoomIn)
        {
            var customerRoom = _customerRoomsService.GetByIdAsync(id);

            if (customerRoom == null)
            {
                return NotFound();
            }

            await _customerRoomsService.UpdateAsync(id, customerRoomIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeleteCustomerRoom(string id)
        {
            var customerRoom = _customerRoomsService.GetByIdAsync(id);

            if (customerRoom == null)
            {
                return NotFound();
            }

            await _customerRoomsService.DeleteAsync(id);

            return NoContent();
        }
    }
}
