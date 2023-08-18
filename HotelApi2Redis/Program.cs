using System;

namespace HotelApi2Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek olarak RedisHelper kullanımı
            var redisHelper = new RedisHelper("localhost:6379");

            // Set işlemi
            redisHelper.Set("testKey", "Hello Redis!");

            // Get işlemi
            var value = redisHelper.Get<string>("testKey");
            Console.WriteLine($"Redis'ten alınan değer: {value}");

            // Delete işlemi
            redisHelper.Delete("testKey");
        }
    }
}
