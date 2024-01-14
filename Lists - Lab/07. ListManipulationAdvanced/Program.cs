using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool valid = false;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];

                if (command == "Add")
                {
                    valid = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    valid = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    valid = true;
                    int index = int.Parse(inputParams[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    valid = true;
                    int number = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, number);
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(inputParams[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }
                else if (command == "Filter")
                {
                    string condition = inputParams[1];
                    int number = int.Parse(inputParams[2]);

                    if(condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }
                }
            }
            if(valid)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
