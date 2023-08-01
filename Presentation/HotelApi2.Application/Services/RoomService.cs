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
        readonly private IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomReadRepository)
        {

            _roomRepository = roomReadRepository;
        }

        public IQueryable<Rooms> GetAll()
        {
            return _roomRepository.GetAll();
        }

        public IQueryable<Rooms> GetWhere(Expression<Func<Rooms, bool>> method)
        {
            return _roomRepository.GetWhere(method);
        }

        public async Task<Rooms> GetSingleAsync(Expression<Func<Rooms, bool>> method)
        {
            return await _roomRepository.GetSingleAsync(method);
        }

        public async Task<Rooms> GetByIdAsync(int id)
        {
            return await _roomRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddAsync(Rooms model)
        {
            return await _roomRepository.AddAsync(model);
        }

        public async Task<bool> AddRangeAsync(List<Rooms> datas)
        {
            return await _roomRepository.AddRangeAsync(datas);
        }

        public bool RemoveRange(List<Rooms> datas)
        {
            return _roomRepository.RemoveRange(datas);
        }

        public bool Remove(Rooms model)
        {
            return _roomRepository.Remove(model);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await _roomRepository.RemoveAsync(id);
        }

        public bool Update(Rooms model)
        {
            return _roomRepository.Update(model);
        }
    }
}
