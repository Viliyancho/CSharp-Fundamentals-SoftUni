using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int max = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(commandArgs[0] == "Add")
                {
                    int num = int.Parse(commandArgs[1]);
                    numbers.Add(num);
                }
                else
                {
                    int passangers = int.Parse(commandArgs[0]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (max >= numbers[i] + passangers)
                        {
                            numbers[i] += passangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
