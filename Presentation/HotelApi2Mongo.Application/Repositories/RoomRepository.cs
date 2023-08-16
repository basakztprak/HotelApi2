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
    public class RoomRepository : IRoomRepository
    {
        private readonly IMongoCollection<Room> _room;

        public RoomRepository(MongoDbContext<Room> context) // Burada doğrudan MongoDbContext<Customer> tipinde bir context'i talep ediyoruz.
        {
            _room = context.Collection; // Context'ten doğrudan koleksiyonu alıyoruz.
        }
        //public RoomRepository(IOptions<MongoDbContext> settings)
        //{
        //    var client = new MongoClient(settings.Value.ConnectionString);
        //    var database = client.GetDatabase(settings.Value.DatabaseName);
        //    _room = database.GetCollection<Room>(settings.Value.RoomsCollectionName);
        //}

        public async Task<List<Room>> GetAllAsync()
        {
            return await _room.Find(room => true).ToListAsync();
        }

        public async Task<Room> GetByIdAsync(string id)
        {
            return await _room.Find<Room>(room => room.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Room> CreateAsync(Room room)
        {
            await _room.InsertOneAsync(room);
            return room;
        }

        public async Task UpdateAsync(string id, Room roomIn)
        {
            await _room.ReplaceOneAsync(room => room.Id == id, roomIn);
        }

        public async Task DeleteAsync(string id)
        {
            await _room.DeleteOneAsync(room => room.Id == id);
        }
    }
}
