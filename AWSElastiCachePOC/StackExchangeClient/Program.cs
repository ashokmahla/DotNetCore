using System;
using System.Collections.Generic;
using StackExchange.Redis;
namespace StackExchangeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConfigurationOptions config = new ConfigurationOptions
            {
                EndPoints =
                {
                    { "mexicotest.9s71yv.0001.use2.cache.amazonaws.com", 6379 }
                    
                },
                CommandMap = CommandMap.Create(new HashSet<string>
                { // EXCLUDE a few commands
                    "INFO", "CONFIG", "CLUSTER",
                    "PING", "ECHO", "CLIENT"
                }, available: false),
                KeepAlive = 180,
                DefaultVersion = new Version(2, 8, 8),
                AbortOnConnectFail = false                 
            };
            var connectionMultiplexer = ConnectionMultiplexer.Connect(config);
            var database = connectionMultiplexer.GetDatabase();
            Console.WriteLine("Done!");
        }
    }
}
