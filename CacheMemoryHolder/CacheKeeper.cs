using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace CacheMemoryHolder
{
    public class CacheKeeper
    {
        public static IMemoryCache? MemoryCache = null;
        private static CacheKeeper? instance = null;
        
        private CacheKeeper() 
        {
        }

        public static CacheKeeper Instance ()
        {
            if (instance == null)
            {
                instance = new CacheKeeper();
            }
            return instance;
        }

        public async Task CreateMemoryCache<T> (T anyObject, string key, int timeInSeconds)
        {
            MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
            memoryCache.Set<T>(key, anyObject, TimeSpan.FromSeconds(timeInSeconds));

            MemoryCache = memoryCache;
        }

        /*public async Task GetItemAsync<T> (MemoryCache memoryCache)
        {
            //List<T>? items;
            T items; // anyObject???
            items = MemoryCache.Get<T>("item");
            //items?.Add(anyObject);

            MemoryCache?.Set("item", items, TimeSpan.FromSeconds(10));
        }*/
    }
}
