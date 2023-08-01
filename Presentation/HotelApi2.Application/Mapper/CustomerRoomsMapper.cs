using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Mapper
{
    public class CustomerRoomsMapper
    {
        public CustomerRooms MapToModel(CustomerRooms customerRoomsEntity)
        {
            return new CustomerRooms
            {
                Id = customerRoomsEntity.Id,
                CustomerId = customerRoomsEntity.CustomerId,
                Customers = MapToModel(customerRoomsEntity.Customers),
                RoomId = customerRoomsEntity.RoomId,
                Rooms = MapToModel(customerRoomsEntity.Rooms)
            };
        }

        public CustomerRooms MapToEntity(CustomerRooms customerRooms)
        {
            return new CustomerRooms
            {
                Id = customerRooms.Id,
                CustomerId = customerRooms.CustomerId,
                Customers = MapToEntity(customerRooms.Customers),
                RoomId = customerRooms.RoomId,
                Rooms = MapToEntity(customerRooms.Rooms)
            };
        }

        private Customers MapToModel(Customers customersEntity)
        {
            return new Customers
            {
                Id = customersEntity.Id,
                CustomerName = customersEntity.CustomerName,
                CustomerSurname = customersEntity.CustomerSurname,
                CustomerId = customersEntity.CustomerId,
                CustomerPhoneNumber = customersEntity.CustomerPhoneNumber
            };
        }

        private Customers MapToEntity(Customers customers)
        {
            return new Customers
            {
                Id = customers.Id,
                CustomerName = customers.CustomerName,
                CustomerSurname = customers.CustomerSurname,
                CustomerId = customers.CustomerId,
                CustomerPhoneNumber = customers.CustomerPhoneNumber
            };
        }

        private Rooms MapToModel(Rooms roomsEntity)
        {
            return new Rooms
            {
                Id = roomsEntity.Id,
                RoomsNumber = roomsEntity.RoomsNumber,
                Floor = roomsEntity.Floor,
                IsEmpty = roomsEntity.IsEmpty,
                Customers = roomsEntity.Customers.Select(MapToModel).ToList()
            };
        }

        private Rooms MapToEntity(Rooms rooms)
        {
            return new Rooms
            {
                Id = rooms.Id,
                RoomsNumber = rooms.RoomsNumber,
                Floor = rooms.Floor,
                IsEmpty = rooms.IsEmpty,
                Customers = rooms.Customers.Select(MapToEntity).ToList()
            };
        }
    }
}
