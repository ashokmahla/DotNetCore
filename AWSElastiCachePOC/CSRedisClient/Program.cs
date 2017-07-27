using System;
using CSRedisClient;

namespace CSRedisClient
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!");
            using (var redis = new CSRedis.RedisClient("mexicotest.9s71yv.0001.use2.cache.amazonaws.com:6379"))
            {
                string ping = redis.Ping();
                string echo = redis.Echo("hello world");
                DateTime time = redis.Time();

            }
        }
    }
}