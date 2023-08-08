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
    public interface ICustomerRoomService
    {
        IQueryable<CustomerRoomDto> GetAll();
        IQueryable<CustomerRoomDto> GetWhere(Expression<Func<CustomerRooms, bool>> method);
        Task<CustomerRoomDto> GetSingleAsync(Expression<Func<CustomerRooms, bool>> method);
        Task<CustomerRoomDto> GetByIdAsync(int id);

        Task<bool> AddAsync(CustomerRoomDto modelDto);
        Task<bool> AddRangeAsync(List<CustomerRoomDto> datasDto);
        bool RemoveRange(List<CustomerRoomDto> datasDto);
        bool Remove(CustomerRoomDto modelDto);
        Task<bool> RemoveAsync(int id);
        bool Update(CustomerRoomDto modelDto);

    }
}
