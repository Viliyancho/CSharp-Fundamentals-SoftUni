using System;
using System.Collections.Generic;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> all = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = commandArgs[0];
                string name = commandArgs[1];
                if(!all.ContainsKey(course))
                {
                    all.Add(course, new List<string>());
                }
                all[course].Add(name);
            }
            foreach (var item in all)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"-- {product}");
                }
            }
        }
    }
}
