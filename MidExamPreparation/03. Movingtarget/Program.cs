using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Movingtarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];
                int index = int.Parse(commandArgs[1]);
                int value = int.Parse(commandArgs[2]);

                if(command == "Shoot")
                {
                    if(index >= 0 && index < target.Count)
                    {
                        target[index] -= value;
                        if (target[index] <= 0)
                        {
                            target.RemoveAt(index);
                        }
                    }
                }
                else if(command == "Add")
                {
                    if (index >= 0 && index < target.Count)
                    {
                        target.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if(command == "Strike")
                {
                    if (index - value >= 0 && index + value < target.Count)
                    {
                        target.RemoveRange(index - value, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }
            Console.WriteLine(string.Join("|", target));
        }
    }
}
