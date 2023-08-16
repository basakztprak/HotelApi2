using HotelApi2Mongo.Application.Data;
using HotelApi2Mongo.Application.Entities;
using HotelApi2Mongo.Application.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoSettings = configuration.GetSection("HotelDatabase").Get<MongoDbContextSettings>();
            services.AddSingleton(mongoSettings);

            // MongoDB contexts
            services.AddSingleton(typeof(MongoDbContext<Customer>));
            services.AddSingleton(typeof(MongoDbContext<Room>));
            services.AddSingleton(typeof(MongoDbContext<CustomerRoom>));

            services.AddSingleton<IRoomRepository, RoomRepository>();
            services.AddSingleton<ICustomerRoomRepository, CustomerRoomRepository>();
            services.AddSingleton<ICustomerRepository, CustomerRepository>();

            services.AddSingleton<IRoomService, RoomService>();
            services.AddSingleton<ICustomerRoomService, CustomerRoomService>();
            services.AddSingleton<ICustomerService, CustomerService>();
        }
    }
}
