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
        IQueryable<Customers> GetAll();
        IQueryable<Customers> GetWhere(Expression<Func<Customers, bool>> method);
        Task<Customers> GetSingleAsync(Expression<Func<Customers, bool>> method);
        Task<Customers> GetByIdAsync(int id);

        Task<bool> AddAsync(Customers model);
        Task<bool> AddRangeAsync(List<Customers> datas);
        bool RemoveRange(List<Customers> datas);
        bool Remove(Customers model);
        Task<bool> RemoveAsync(int id);
        bool Update(Customers model);
    }
}
