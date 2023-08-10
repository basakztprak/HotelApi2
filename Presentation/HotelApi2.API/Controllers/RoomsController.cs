using FluentValidation;
using HotelApi2.Application.Models;
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
        private readonly IValidator<RoomDto> _roomValidator;

        public RoomsController(IRoomService roomService, IValidator<RoomDto> roomValidator)
        {
            _roomService = roomService;
            _roomValidator = roomValidator;
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
        public async Task<ActionResult<Rooms>> Post(RoomDto roomDto)
        {
            var validationResult = _roomValidator.Validate(roomDto);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            var success = await _roomService.AddAsync(roomDto);
            return Ok(roomDto);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(RoomDto roomDto)
        {

            bool response = _roomService.Update(roomDto);
            return Ok(roomDto);


        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool response = await _roomService.RemoveAsync(id);
            return Ok(response);
        }
    }
}
