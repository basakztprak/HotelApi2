using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Services
{
    public interface ICustomerRoomService
    {
        IQueryable<CustomerRooms> GetAll();
        IQueryable<CustomerRooms> GetWhere(Expression<Func<CustomerRooms, bool>> method);
        Task<CustomerRooms> GetSingleAsync(Expression<Func<CustomerRooms, bool>> method);
        Task<CustomerRooms> GetByIdAsync(int id);

        Task<bool> AddAsync(CustomerRooms model);
        Task<bool> AddRangeAsync(List<CustomerRooms> datas);
        bool RemoveRange(List<CustomerRooms> datas);
        bool Remove(CustomerRooms model);
        Task<bool> RemoveAsync(int id);
        bool Update(CustomerRooms model);

    }
}
