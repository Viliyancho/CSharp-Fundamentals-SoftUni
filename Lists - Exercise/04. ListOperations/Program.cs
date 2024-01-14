using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];

                if (command == "Add")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);

                    if (ValidIndex(numbers, index))
                    {
                        numbers.Insert(index, number);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (ValidIndex(numbers, index))
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Shift")
                {
                    string direction = commandArgs[1];
                    int count = int.Parse(commandArgs[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool ValidIndex(List<int> numbers, int index)
        {
            if (index < 0 || index >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return false;
            }
            return true;
        }
    }
}
