//using CacheMemoryHolder;
//using Microsoft.Extensions.Caching.Memory;

//Person person1 = new Person() { Id = "1", Name = "Eviatar" };
//int number = 99;
///*Person person2 = new Person() { Id = "2", Name = "Tali" };
//Person person3 = new Person() { Id = "3", Name = "Shai" };
//List<Person> list = new List<Person> { person1, person2, person3 };*/

//CacheKeeper.Instance().CreateMemoryCache(person1, "person1", 10);
//CacheKeeper.Instance().CreateMemoryCache(number, "number", 10);
//Console.WriteLine(CacheKeeper.Instance().GetDataFromCache<Person>("person1").Name);
//int? a = CacheKeeper.Instance().GetDataFromCache<int>("number");
//Console.WriteLine(a);

//Thread.Sleep(11000);

//try
//{
//    Console.WriteLine(CacheKeeper.Instance().GetDataFromCache<Person>("person1").Name);
//    Console.WriteLine(CacheKeeper.Instance().GetDataFromCache<int>("number"));
//}
//catch
//{
//    Console.WriteLine("Keys are null!");
//}
///*await Holder.Instance().CreateMemoryCache(person2, "person2", 10);
//await Holder.Instance().CreateMemoryCache(person3, "person3", 10);*/

///*List<Person> people = null;
//CacheKeeper.MemoryCache?.TryGetValue("person1", out people);
//foreach(var v in people)
//{
//    Console.WriteLine(v.Id);
//}

//Thread.Sleep(11000);

//CacheKeeper.MemoryCache?.TryGetValue("person1", out people);
//try
//{
//    foreach (var v in people)
//    {
//        Console.WriteLine(v.Id);
//    }
//} catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}*/
///*Person? newPerson1 = null;
//Person? newPerson2 = null;
//Holder.MemoryCache?.TryGetValue("person", out newPerson1);
//Console.WriteLine("Id1:" + newPerson1?.Id);
//Thread.Sleep(11000);
//Holder.MemoryCache?.TryGetValue("person", out newPerson2);
//Console.WriteLine("Id2:" + newPerson2?.Id);*/

//Console.ReadKey();

///*
// using System;
//using System.Runtime.Caching;

//class Program
//{
//    static void Main()
//    {
//        // Creating a MemoryCache instance
//        MemoryCache cache = MemoryCache.Default;

//        // Adding an item to the cache with a key and value, and specifying cache options (e.g., expiration time)
//        cache.Add("Key1", "Value1", DateTimeOffset.Now.AddMinutes(10));

//        // Retrieving a cached item using its key
//        object cachedValue = cache.Get("Key1");
//        if (cachedValue != null)
//        {
//            Console.WriteLine("Cached Value: " + cachedValue.ToString());
//        }
//        else
//        {
//            Console.WriteLine("Key1 not found in the cache.");
//        }

//        // Removing an item from the cache using its key
//        cache.Remove("Key1");

//        // Checking if an item exists in the cache
//        bool itemExists =
//*/