using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2Redis
{
    public class RedisHelper
    {
        private readonly ConnectionMultiplexer _redisConnection;
        private readonly IDatabase _database;

        public RedisHelper(string connectionString)
        {
            _redisConnection = ConnectionMultiplexer.Connect(connectionString);
            _database = _redisConnection.GetDatabase();
        }

        public bool Set<T>(string key, T value)
        {
            var jsonData = JsonConvert.SerializeObject(value);
            return _database.StringSet(key, jsonData);
        }

        public T Get<T>(string key)
        {
            var jsonData = _database.StringGet(key);
            if (jsonData.IsNullOrEmpty)
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public bool Delete(string key)
        {
            return _database.KeyDelete(key);
        }
    }
}
