using HotelApi2.Application.Models;
using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Services
{
    public interface IRoomService
    {
        IQueryable<RoomDto> GetAll();
        IQueryable<RoomDto> GetWhere(Expression<Func<Rooms, bool>> method);
        Task<RoomDto> GetSingleAsync(Expression<Func<Rooms, bool>> method);
        Task<RoomDto> GetByIdAsync(int id);

        Task<bool> AddAsync(RoomDto modelDto);
        Task<bool> AddRangeAsync(List<RoomDto> datasDto);
        bool RemoveRange(List<RoomDto> datasDto);
        bool Remove(RoomDto modelDto);
        Task<bool> RemoveAsync(int id);
        bool Update(RoomDto modelDto);
    }
}
