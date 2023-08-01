using HotelApi2.Application.Services;
using HotelApi2.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        readonly private IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok("Merhaba");
        //}

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var room = _roomService.GetAll();
            return Ok(room);

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var room = await _roomService.GetByIdAsync(id);
            return Ok(room);
        }

        [HttpPost]
        public async Task<ActionResult<Rooms>> Post(Rooms customerRoom)
        {
            var success = await _roomService.AddAsync(customerRoom);
            return Ok(customerRoom);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Rooms room)
        {

            bool response = _roomService.Update(room);
            return Ok(room);


        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool response = await _roomService.RemoveAsync(id);
            return Ok(response);
        }
    }
}
