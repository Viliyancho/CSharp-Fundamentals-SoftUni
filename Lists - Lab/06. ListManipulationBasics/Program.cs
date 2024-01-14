using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParams = input.Split();

                string command = inputParams[0];

                if(command == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(inputParams[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
