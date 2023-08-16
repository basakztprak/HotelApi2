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
    public class CustomerRepository : ICustomerRepository
    {

        private readonly IMongoCollection<Customer> _customer;
        public CustomerRepository(MongoDbContext<Customer> context) // Burada doğrudan MongoDbContext<Customer> tipinde bir context'i talep ediyoruz.
        {
            _customer = context.Collection; // Context'ten doğrudan koleksiyonu alıyoruz.
        }
        

        //public CustomerRepository(MongoDbContext context) // Burada doğrudan MongoDbContext'ü talep ediyoruz.
        //{
        //    _customer = context.Customers; // MongoDbContext içinde tanımlanan Customers koleksiyonunu kullanıyoruz.
        //}
        //public CustomerRepository(IOptions<MongoDbContext> settings)
        //{
        //    var client = new MongoClient(settings.Value.ConnectionString);
        //    var database = client.GetDatabase(settings.Value.DatabaseName);
        //    _customer = database.GetCollection<Customer>(settings.Value.CustomersCollectionName);
        //}

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _customer.Find(customer => true).ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(string id)
        {
            return await _customer.Find<Customer>(customer => customer.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Customer> CreateAsync(Customer customer)
        {
            await _customer.InsertOneAsync(customer);
            return customer;
        }

        public async Task UpdateAsync(string id, Customer customerIn)
        {
            await _customer.ReplaceOneAsync(customer => customer.Id == id, customerIn);
        }

        public async Task DeleteAsync(string id)
        {
            await _customer.DeleteOneAsync(customer => customer.Id == id);
        }
    }
}
