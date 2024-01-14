using System;
using System.Collections.Generic;

namespace _3._WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> all = new Dictionary<string, List<string>>();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!all.ContainsKey(key))
                {
                    all.Add(key, new List<string>());
                }
                all[key].Add(value);
            }

            foreach (var item in all)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
