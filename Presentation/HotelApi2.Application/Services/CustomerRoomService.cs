using AutoMapper;
using HotelApi2.Application.Models;
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
        private readonly ICustomerRoomRepository _customerRoomRepository;
        private readonly IMapper _mapper;

        public CustomerRoomService(ICustomerRoomRepository customerRoomRepository, IMapper mapper)
        {
            _customerRoomRepository = customerRoomRepository;
            _mapper = mapper;

        }

        public IQueryable<CustomerRoomDto> GetAll()
        {
            var customerRoom = _customerRoomRepository.GetAll();
            return _mapper.ProjectTo<CustomerRoomDto>(customerRoom);
        }

        public IQueryable<CustomerRoomDto> GetWhere(Expression<Func<CustomerRooms, bool>> method)
        {
            var customerRoom = _customerRoomRepository.GetWhere(method);
            return _mapper.ProjectTo<CustomerRoomDto>(customerRoom);
        }

        public async Task<CustomerRoomDto> GetSingleAsync(Expression<Func<CustomerRooms, bool>> method)
        {
            var customerRoom = await _customerRoomRepository.GetSingleAsync(method);
            return _mapper.Map<CustomerRoomDto>(customerRoom);
        }

        public async Task<CustomerRoomDto> GetByIdAsync(int id)
        {
            var customerRoom = await _customerRoomRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerRoomDto>(customerRoom);
        }

        public async Task<bool> AddAsync(CustomerRoomDto modelDto)
        {
            var model = _mapper.Map<CustomerRooms>(modelDto);
            return await _customerRoomRepository.AddAsync(model);
        }

        public async Task<bool> AddRangeAsync(List<CustomerRoomDto> datasDto)
        {
            var datas = _mapper.Map<List<CustomerRooms>>(datasDto);
            return await _customerRoomRepository.AddRangeAsync(datas); ;
        }

        public bool RemoveRange(List<CustomerRoomDto> datasDto)
        {
            var datas = _mapper.Map<List<CustomerRooms>>(datasDto);
            return _customerRoomRepository.RemoveRange(datas);
        }

        public bool Remove(CustomerRoomDto modelDto)
        {
            var model = _mapper.Map<CustomerRooms>(modelDto);
            return _customerRoomRepository.Remove(model);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await _customerRoomRepository.RemoveAsync(id);
        }

        public bool Update(CustomerRoomDto modelDto)
        {
            var model = _mapper.Map<CustomerRooms>(modelDto);
            return _customerRoomRepository.Update(model);
        }
    }
}
