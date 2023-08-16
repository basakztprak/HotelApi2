using HotelApi2Mongo.Application.Entities;
using HotelApi2Mongo.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> GetAllAsync() =>
            await _customerRepository.GetAllAsync();

        public async Task<Customer> GetByIdAsync(string id) =>
            await _customerRepository.GetByIdAsync(id);

        public async Task<Customer> CreateAsync(Customer customer) =>
            await _customerRepository.CreateAsync(customer);

        public async Task UpdateAsync(string id, Customer customer) =>
            await _customerRepository.UpdateAsync(id, customer);

        public async Task DeleteAsync(string id) =>
            await _customerRepository.DeleteAsync(id);
    }
}
