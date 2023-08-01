using HotelApi2.Domain.Entities;
using HotelApi2.Domain.Repositories.CustomerRoomRepository;
using HotelApi2.Infastructure.Repositories.CustomerRoomRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Services
{
    public class CustomerRoomService : ICustomerRoomService
    {
        readonly private ICustomerRoomRepository _customerRoomRepository;

        public CustomerRoomService(ICustomerRoomRepository customerRoomRepository)
        {
            _customerRoomRepository = customerRoomRepository;

        }

        public IQueryable<CustomerRooms> GetAll()
        {
            return _customerRoomRepository.GetAll();
        }

        public IQueryable<CustomerRooms> GetWhere(Expression<Func<CustomerRooms, bool>> method)
        {
            return _customerRoomRepository.GetWhere(method);
        }

        public async Task<CustomerRooms> GetSingleAsync(Expression<Func<CustomerRooms, bool>> method)
        {
            return await _customerRoomRepository.GetSingleAsync(method);
        }

        public async Task<CustomerRooms> GetByIdAsync(int id)
        {
            return await _customerRoomRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddAsync(CustomerRooms model)
        {
            return await _customerRoomRepository.AddAsync(model);
        }

        public async Task<bool> AddRangeAsync(List<CustomerRooms> datas)
        {
            return await _customerRoomRepository.AddRangeAsync(datas);
        }

        public bool RemoveRange(List<CustomerRooms> datas)
        {
            return _customerRoomRepository.RemoveRange(datas);
        }

        public bool Remove(CustomerRooms model)
        {
            return _customerRoomRepository.Remove(model);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await _customerRoomRepository.RemoveAsync(id);
        }

        public bool Update(CustomerRooms model)
        {
            return _customerRoomRepository.Update(model);
        }
    }
}
