using System;
using StackExchange.Redis;
namespace SendReceiveCache
{
    public class Program
    {
        private static readonly Lazy<ConnectionMultiplexer> LazyConnection;

        static Program()
        {
            try
            {
                LazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect("mexicotest.9s71yv.0001.use2.cache.amazonaws.com:6379"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            GetSetData();
        }

        public static ConnectionMultiplexer Connection => LazyConnection.Value;

        public static IDatabase RedisCache => Connection.GetDatabase();

        public static void GetSetData()
        {
            try
            {
                var redis = Program.RedisCache;
                if (RedisCache.StringSet("testKey", "testValue"))
                {
                    var val = RedisCache.StringGet("testKey");

                    Console.WriteLine(val);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
