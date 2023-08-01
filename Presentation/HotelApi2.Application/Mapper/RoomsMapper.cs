using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Mapper
{
    public class RoomsMapper
    {
        private readonly CustomersMapper _customersMapper;

        public RoomsMapper(CustomersMapper customersMapper)
        {
            _customersMapper = customersMapper;
        }

        public Rooms MapToModel(Rooms roomsEntity)
        {
            return new Rooms
            {
                Id = roomsEntity.Id,
                RoomsNumber = roomsEntity.RoomsNumber,
                Floor = roomsEntity.Floor,
                IsEmpty = roomsEntity.IsEmpty,
                Customers = roomsEntity.Customers.Select(c => _customersMapper.MapToModel(c)).ToList()
            };
        }

        public Rooms MapToEntity(Rooms rooms)
        {
            return new Rooms
            {
                Id = rooms.Id,
                RoomsNumber = rooms.RoomsNumber,
                Floor = rooms.Floor,
                IsEmpty = rooms.IsEmpty,
                Customers = rooms.Customers.Select(c => _customersMapper.MapToEntity(c)).ToList()
            };
        }
    }
}

