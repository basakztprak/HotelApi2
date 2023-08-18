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
    public interface ICustomerService
    {
        IQueryable<CustomerDto> GetAll();
        IQueryable<CustomerDto> GetWhere(Expression<Func<Customers, bool>> method);
        Task<CustomerDto> GetSingleAsync(Expression<Func<Customers, bool>> method);
        Task<CustomerDto> GetByIdAsync(int id);

        Task<bool> AddAsync(CustomerDto modelDto);
        Task<bool> AddRangeAsync(List<CustomerDto> datasDto);
        bool RemoveRange(List<CustomerDto> datasDto);
        bool Remove(CustomerDto modelDto);
        Task<bool> RemoveAsync(int id);
        bool Update(CustomerDto modelDto);
        CustomerWithRoomDto GetCustomerWithRoom(int customerId);
        CustomerWithRoomDto2 GetCustomerWithRoom2(int customerId);
    }
}
