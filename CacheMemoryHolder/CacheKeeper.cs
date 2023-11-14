using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace CacheMemoryHolder
{
    public class CacheKeeper
    {
        public static MemoryCache? MemoryCache = new MemoryCache(new MemoryCacheOptions());
        private static CacheKeeper? instance = null;

        private CacheKeeper()
        {
        }

        public static CacheKeeper Instance()
        {
            if (instance == null)
            {
                instance = new CacheKeeper();
            }
            return instance;
        }

        public async void CreateMemoryCache<T>(T anyObject, string key, int timeInSeconds)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(timeInSeconds)
            };
            MemoryCache.Set<T>(key, anyObject, cacheEntryOptions);
        }


        public T GetDataFromCache<T>(string? key = null)
        {
                T? result;
                MemoryCache.TryGetValue(key, out result);
                return result;
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