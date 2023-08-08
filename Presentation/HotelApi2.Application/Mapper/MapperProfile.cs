using AutoMapper;
using HotelApi2.Application.Models;
using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CustomerRooms, CustomerRoomDto>();
            CreateMap<CustomerRoomDto, CustomerRooms>();
            CreateMap<Customers, CustomerDto>();
            CreateMap<CustomerDto, Customers>();
            CreateMap<Rooms, RoomDto>();
            CreateMap<RoomDto, Rooms>();


        }
    }

 }

