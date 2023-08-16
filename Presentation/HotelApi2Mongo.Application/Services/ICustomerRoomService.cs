using HotelApi2Mongo.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Services
{
    public interface ICustomerRoomService
    {
        Task<List<CustomerRoom>> GetAllAsync();
        Task<CustomerRoom> GetByIdAsync(string id);
        Task<CustomerRoom> CreateAsync(CustomerRoom customerRoom);
        Task UpdateAsync(string id, CustomerRoom customerRoomIn);
        Task DeleteAsync(string id);
    }
}
