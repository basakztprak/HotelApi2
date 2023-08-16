using HotelApi2Mongo.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Repositories
{
    public interface ICustomerRoomRepository
    {
        Task<List<CustomerRoom>> GetAllAsync();
        Task<CustomerRoom> GetByIdAsync(string id);
        Task<CustomerRoom> CreateAsync(CustomerRoom customerRoom);
        Task UpdateAsync(string id, CustomerRoom customerRoomIn);
        Task DeleteAsync(string id);
    }
}
