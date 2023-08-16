using HotelApi2Mongo.Application.Entities;
using HotelApi2Mongo.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await _roomRepository.GetAllAsync();
        }

        public async Task<Room> GetByIdAsync(string id)
        {
            return await _roomRepository.GetByIdAsync(id);
        }

        public async Task<Room> CreateAsync(Room room)
        {
            return await _roomRepository.CreateAsync(room);
        }

        public async Task UpdateAsync(string id, Room room)
        {
            await _roomRepository.UpdateAsync(id, room);
        }

        public async Task DeleteAsync(string id)
        {
            await _roomRepository.DeleteAsync(id);
        }
    }
}
