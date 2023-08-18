using AutoMapper;
using HotelApi2.Application.Models;
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
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        //readonly private ICustomerRepository _customerRepository;
        //readonly private IMapper _mapper;


        //public CustomerService(ICustomerRepository customerRepository)
        //{
        //    _customerRepository = customerRepository;

        //}

        //public CustomerService(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        public IQueryable<CustomerDto> GetAll()
        {
            var customers = _customerRepository.GetAll();
            return _mapper.ProjectTo<CustomerDto>(customers);
            //return _mapper.Map<Customers>(CustomerDto);
        }

        public IQueryable<CustomerDto> GetWhere(Expression<Func<Customers, bool>> method)
        {
            var customers = _customerRepository.GetWhere(method);
            return _mapper.ProjectTo<CustomerDto>(customers);
        }

        public async Task<CustomerDto> GetSingleAsync(Expression<Func<Customers, bool>> method)
        {
            var customer = await _customerRepository.GetSingleAsync(method);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<CustomerDto> GetByIdAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            //var temp = _mapper.Map<CustomerDto>(customer);
            return _mapper.Map<CustomerDto>(customer);
            //return await _customerRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddAsync(CustomerDto modelDto)
        {
            var model = _mapper.Map<Customers>(modelDto);
            return await _customerRepository.AddAsync(model);
        }

        public async Task<bool> AddRangeAsync(List<CustomerDto> datasDto)
        {
            var datas = _mapper.Map<List<Customers>>(datasDto);
            return await _customerRepository.AddRangeAsync(datas);
        }

        public bool RemoveRange(List<CustomerDto> datasDto)
        {
            var datas = _mapper.Map<List<Customers>>(datasDto);
            return _customerRepository.RemoveRange(datas);
        }

        public bool Remove(CustomerDto modelDto)
        {
            var model = _mapper.Map<Customers>(modelDto);
            return _customerRepository.Remove(model);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await _customerRepository.RemoveAsync(id);
        }

        public bool Update(CustomerDto modelDto)
        {
            var model = _mapper.Map<Customers>(modelDto);
            return _customerRepository.Update(model);
        }
        public CustomerWithRoomDto GetCustomerWithRoom(int customerId)
        {
            var customer = _customerRepository.GetCustomerWithRoom(customerId);
            return _mapper.Map<CustomerWithRoomDto>(customer);
        }

        public CustomerWithRoomDto2 GetCustomerWithRoom2(int customerId)
        {
            var customer = _customerRepository.GetCustomerWithRoom2(customerId);
            return _mapper.Map<CustomerWithRoomDto2>(customer);
        }

    }
}
