using FluentAssertions.Common;
using HotelApi2.Application.Mapper;
using HotelApi2.Domain.Repositories.CustomerRepository;
using HotelApi2.Domain.Repositories.CustomerRoomRepository;
using HotelApi2.Domain.Repositories.RoomRepository;
using HotelApi2.Infastructure.Data;
using HotelApi2.Infastructure.Repositories.CustomerRepository;
using HotelApi2.Infastructure.Repositories.CustomerRoomRepository;
using HotelApi2.Infastructure.Repositories.RoomRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Services
{
    public static class ServiceRegistrations
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            //Depency Injection
            services.AddScoped<MyDbContext>();
            services.AddScoped<ICustomerRoomRepository, CustomerRoomRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<ICustomerRoomService, CustomerRoomService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddAutoMapper(typeof(MapperProfile).Assembly);

        }
    }
}
