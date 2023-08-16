using HotelApi2Mongo.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Repositories
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetAllAsync();
        Task<Room> GetByIdAsync(string id);
        Task<Room> CreateAsync(Room room);
        Task UpdateAsync(string id, Room roomIn);
        Task DeleteAsync(string id);
    }
}
