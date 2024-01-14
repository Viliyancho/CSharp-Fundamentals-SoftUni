using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> all = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
                
                foreach (var item in numbers)
                {
                    if(!all.ContainsKey(item))
                    {
                        all.Add(item, 0);
                    }
                all[item]++;
                }

            foreach (var item in all)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
