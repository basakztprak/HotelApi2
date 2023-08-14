using FluentValidation;
using HotelApi2.Application.Models;
using HotelApi2.Application.Services;
using HotelApi2.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mqtt;

namespace HotelApi2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        readonly private IRoomService _roomService;
        private readonly IValidator<RoomDto> _roomValidator;
        private readonly MqttPublisher _mqttPublisher;
        //var publisher = new MqttPublisher();
        //publisher.Publish("someTopic", "someMessage");

        public RoomsController(IRoomService roomService, IValidator<RoomDto> roomValidator, MqttPublisher mqttPublisher)
        {
            _roomService = roomService;
            _roomValidator = roomValidator;
            _mqttPublisher = mqttPublisher;
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
            if (success)
            {
                if (_mqttPublisher.IsConnected)
                {
                    await _mqttPublisher.PublishAsync("reservation", "Rezervasyon yapıldı!");
                }
                else
                {
                    // Burada, bağlantı başarısız olduğunda yapılacak işlemleri tanımlayabilirsiniz.
                    // Örneğin: Bir hata log'u kaydedebilirsiniz.
                    //_logger.LogError("MQTT Publisher bağlantı kuramadı.");
                }
            }


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
