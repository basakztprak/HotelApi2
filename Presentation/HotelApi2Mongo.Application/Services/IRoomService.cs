using HotelApi2Mongo.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Services
{
    public interface IRoomService
    {
        Task<List<Room>> GetAllAsync();
        Task<Room> GetByIdAsync(string id);
        Task<Room> CreateAsync(Room Room);
        Task UpdateAsync(string id, Room RoomIn);
        Task DeleteAsync(string id);
    }
}
