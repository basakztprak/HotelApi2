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
        IQueryable<Rooms> GetAll();
        IQueryable<Rooms> GetWhere(Expression<Func<Rooms, bool>> method);
        Task<Rooms> GetSingleAsync(Expression<Func<Rooms, bool>> method);
        Task<Rooms> GetByIdAsync(int id);

        Task<bool> AddAsync(Rooms model);
        Task<bool> AddRangeAsync(List<Rooms> datas);
        bool RemoveRange(List<Rooms> datas);
        bool Remove(Rooms model);
        Task<bool> RemoveAsync(int id);
        bool Update(Rooms model);
    }
}
