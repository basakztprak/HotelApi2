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
            CreateMap<Rooms, RoomWithCustomersDto>();
            CreateMap<Customers, CustomerWithRoomDto>()
                  .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.Room)); // obje olarak döndürüldü

            CreateMap<Customers, CustomerWithRoomDto2>()
                .ForMember(dest => dest.RoomId, opt => opt.MapFrom(src => src.Room.Id))  // tek tek döndürüldü
                .ForMember(dest => dest.RoomsNumber, opt => opt.MapFrom(src => src.Room.RoomsNumber)) // tek tek
                .ForMember(dest => dest.Floor, opt => opt.MapFrom(src => src.Room.Floor)); // tek tek
           


        }
    }

 }

