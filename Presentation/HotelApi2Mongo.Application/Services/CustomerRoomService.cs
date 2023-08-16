using HotelApi2Mongo.Application.Entities;
using HotelApi2Mongo.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Services
{
    public class CustomerRoomService : ICustomerRoomService
    {
        private readonly ICustomerRoomRepository _customerRoomRepository;

        public CustomerRoomService(ICustomerRoomRepository customerRoomRepository)
        {
            _customerRoomRepository = customerRoomRepository;
        }

        public async Task<List<CustomerRoom>> GetAllAsync() =>
            await _customerRoomRepository.GetAllAsync();

        public async Task<CustomerRoom> GetByIdAsync(string id) =>
            await _customerRoomRepository.GetByIdAsync(id);

        public async Task<CustomerRoom> CreateAsync(CustomerRoom customerRoom) =>
            await _customerRoomRepository.CreateAsync(customerRoom);

        public async Task UpdateAsync(string id, CustomerRoom customerRoom) =>
            await _customerRoomRepository.UpdateAsync(id, customerRoom);

        public async Task DeleteAsync(string id) =>
            await _customerRoomRepository.DeleteAsync(id);
    }
}

