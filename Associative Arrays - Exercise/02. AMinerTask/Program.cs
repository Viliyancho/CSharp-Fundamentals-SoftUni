using System;
using System.Collections.Generic;

namespace _02._AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> all = new Dictionary<string, int>();

            string resource = string.Empty;
            while((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if(!all.ContainsKey(resource))
                {
                    all.Add(resource, 0);
                }
                all[resource] += quantity;
            }
            foreach (var item in all)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
