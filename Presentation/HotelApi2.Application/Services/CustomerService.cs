using HotelApi2.Domain.Entities;
using HotelApi2.Domain.Repositories.CustomerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Services
{
    public class CustomerService : ICustomerService
    {
        readonly private ICustomerRepository _customerRepository;
        

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }

        public IQueryable<Customers> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public IQueryable<Customers> GetWhere(Expression<Func<Customers, bool>> method)
        {
            return _customerRepository.GetWhere(method);
        }

        public async Task<Customers> GetSingleAsync(Expression<Func<Customers, bool>> method)
        {
            return await _customerRepository.GetSingleAsync(method);
        }

        public async Task<Customers> GetByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddAsync(Customers model)
        {
            return await _customerRepository.AddAsync(model);
        }

        public async Task<bool> AddRangeAsync(List<Customers> datas)
        {
            return await _customerRepository.AddRangeAsync(datas);
        }

        public bool RemoveRange(List<Customers> datas)
        {
            return _customerRepository.RemoveRange(datas);
        }

        public bool Remove(Customers model)
        {
            return _customerRepository.Remove(model);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await _customerRepository.RemoveAsync(id);
        }

        public bool Update(Customers model)
        {
            return _customerRepository.Update(model);
        }
    }
}
