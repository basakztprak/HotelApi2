using HotelApi2Mongo.Application.Entities;
using HotelApi2Mongo.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi2Mongo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomsService;

        public RoomsController(IRoomService roomsService)
        {
            _roomsService = roomsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Room>>> GetAll()
        {
            return await _roomsService.GetAllAsync();
        }

        [HttpGet("{id:length(24)}", Name = "GetRoom")]
        public async Task<ActionResult<Room>> GetById(string id)
        {
            var room = await _roomsService.GetByIdAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }

        [HttpPost]
        public async Task<ActionResult<Room>> Create(Room room)
        {
            await _roomsService.CreateAsync(room);

            return CreatedAtRoute("GetRoom", new { id = room.Id.ToString() }, room);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Room roomIn)
        {
            var room = _roomsService.GetByIdAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            await _roomsService.UpdateAsync(id, roomIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var room = _roomsService.GetByIdAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            await _roomsService.DeleteAsync(id);

            return NoContent();
        }
    }
}
