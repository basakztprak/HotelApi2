using HotelApi2Mongo.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(string id);
        Task<Customer> CreateAsync(Customer customer);
        Task UpdateAsync(string id, Customer customerIn);
        Task DeleteAsync(string id);
    }
}
