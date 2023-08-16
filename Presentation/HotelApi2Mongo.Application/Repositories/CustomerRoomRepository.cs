using HotelApi2Mongo.Application.Data;
using HotelApi2Mongo.Application.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Mongo.Application.Repositories
{
    public class CustomerRoomRepository : ICustomerRoomRepository
    {
        private readonly IMongoCollection<CustomerRoom> _customerRoom;

        public CustomerRoomRepository(MongoDbContext<CustomerRoom> context) // Burada doğrudan MongoDbContext<Customer> tipinde bir context'i talep ediyoruz.
        {
            _customerRoom = context.Collection; // Context'ten doğrudan koleksiyonu alıyoruz.
        }
        //public CustomerRoomRepository(IOptions<MongoDbContext> settings)
        //{
        //    var client = new MongoClient(settings.Value.ConnectionString);
        //    var database = client.GetDatabase(settings.Value.DatabaseName);
        //    _customerRoom = database.GetCollection<CustomerRoom>(settings.Value.CustomerRoomsCollectionName);
        //}


        public async Task<List<CustomerRoom>> GetAllAsync()
        {
            return await _customerRoom.Find(customerRoom => true).ToListAsync();
        }

        public async Task<CustomerRoom> GetByIdAsync(string id)
        {
            return await _customerRoom.Find<CustomerRoom>(customerRoom => customerRoom.Id == id).FirstOrDefaultAsync();
        }

        public async Task<CustomerRoom> CreateAsync(CustomerRoom customerRoom)
        {
            await _customerRoom.InsertOneAsync(customerRoom);
            return customerRoom;
        }

        public async Task UpdateAsync(string id, CustomerRoom customerRoomIn)
        {
            await _customerRoom.ReplaceOneAsync(customerRoom => customerRoom.Id == id, customerRoomIn);
        }

        public async Task DeleteAsync(string id)
        {
            await _customerRoom.DeleteOneAsync(customerRoom => customerRoom.Id == id);
        }
    }
}
