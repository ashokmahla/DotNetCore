using System;
using Enyim.Caching;
using Amazon.ElastiCacheCluster;

namespace VSElasticCache
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Creating config...");                
                ElastiCacheClusterConfig config = new ElastiCacheClusterConfig("mexicotest.9s71yv.0001.use2.cache.amazonaws.com", 6379);

                Console.WriteLine("Creating client...");
                MemcachedClient client = new MemcachedClient(config);

                if (client.Store(Enyim.Caching.Memcached.StoreMode.Set, "Demo", "Hello World"))
                {
                    Console.WriteLine("Stored to cache successfully");
                }
                else
                {
                    Console.WriteLine("Did not store to cache successfully");
                }

                Object value;
                if (client.TryGet("Demo", out value))
                {
                    Console.WriteLine("Got the value: " + (value as string));
                }
                else
                {
                    // Search Database if the get fails
                    Console.WriteLine("Checking database because get failed");
                }

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
