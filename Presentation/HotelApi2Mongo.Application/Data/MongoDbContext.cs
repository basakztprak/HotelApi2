using HotelApi2Mongo.Application.Entities.Common;
using MongoDB.Driver;

namespace HotelApi2Mongo.Application.Data
{
    public class MongoDbContext<T> where T : BaseEntity
    {
        private readonly IMongoDatabase _database;
        private readonly MongoDbContextSettings _settings;

        public MongoDbContext(MongoDbContextSettings settings)
        {
            _settings = settings;
            var client = new MongoClient(settings.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<T> Collection
        {
            get
            {
                // Koleksiyon adını sınıf adına göre al. Örneğin, "Customer" için "Customers" koleksiyonuna erişir.
                string collectionName = typeof(T).Name + "s";
                return _database.GetCollection<T>(collectionName);
            }
        }
    }
}





//namespace HotelApi2Mongo.Application.Data
//{
//    public class MongoDbContext
//    {
//        public string ConnectionString { get; set; }
//        public string DatabaseName { get; set; }
//        public string CustomerRoomsCollectionName { get; set; }
//        public string CustomersCollectionName { get; set; }
//        public string RoomsCollectionName { get; set; }
//    }
//}
