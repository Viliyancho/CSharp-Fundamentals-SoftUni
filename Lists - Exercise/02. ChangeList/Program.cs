using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ChangeList
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
            while((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];

                if(command == "Delete")
                {
                    int num = int.Parse(commandArgs[1]);
                    numbers.RemoveAll(x => x == num);
                }
                else if(command == "Insert")
                {
                    int num = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, num);
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
