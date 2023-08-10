using AutoMapper;
using FluentValidation;
using HotelApi2.Application.Models;
using HotelApi2.Domain.Entities;
using HotelApi2.Domain.Repositories.RoomRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Services
{
    public class RoomService : IRoomService
        {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        //private readonly IValidator<Rooms> _roomValidator;

        public RoomService(IRoomRepository roomReadRepository, IMapper mapper)
        {

            _roomRepository = roomReadRepository;
            _mapper = mapper;
        }

        public IQueryable<RoomDto> GetAll()
        {
            var room = _roomRepository.GetAll();
            return _mapper.ProjectTo<RoomDto>(room);
        }

        public IQueryable<RoomDto> GetWhere(Expression<Func<Rooms, bool>> method)
        {
            var room = _roomRepository.GetWhere(method);
            return _mapper.ProjectTo<RoomDto>(room);
        }

        public async Task<RoomDto> GetSingleAsync(Expression<Func<Rooms, bool>> method)
        {
            var room = await _roomRepository.GetSingleAsync(method);
            return _mapper.Map<RoomDto>(room);
        }

        public async Task<RoomDto> GetByIdAsync(int id)
        {
            var room = await _roomRepository.GetByIdAsync(id);
            return _mapper.Map<RoomDto>(room);
           
        }

        public async Task<bool> AddAsync(RoomDto modelDto)
        {
            var model = _mapper.Map<Rooms>(modelDto);
            return await _roomRepository.AddAsync(model);
        }

        public async Task<bool> AddRangeAsync(List<RoomDto> datasDto)
        {
            var datas = _mapper.Map<List<Rooms>>(datasDto);
            return await _roomRepository.AddRangeAsync(datas);
        }

        public bool RemoveRange(List<RoomDto> datasDto)
        {
            var datas = _mapper.Map<List<Rooms>>(datasDto);
            return _roomRepository.RemoveRange(datas);
        }

        public bool Remove(RoomDto modelDto)
        {
            var model = _mapper.Map<Rooms>(modelDto);
            return _roomRepository.Remove(model);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await _roomRepository.RemoveAsync(id);
        }

        public bool Update(RoomDto modelDto)
        {
            var model = _mapper.Map<Rooms>(modelDto);
            return _roomRepository.Update(model);
        }
    }
}
