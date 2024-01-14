using System;
using System.Collections.Generic;

namespace _04._SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> all = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string name = commandArgs[1];

                if(command == "register")
                {
                    string number = commandArgs[2];
                    if(all.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                    }
                    else
                    {
                        all.Add(name, number);
                        Console.WriteLine($"{name} registered {number} successfully");
                    }
                }
                else if(command == "unregister")
                {
                    if(!all.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        all.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (var item in all)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
