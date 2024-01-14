using System;
using System.Collections.Generic;

namespace _03._HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(person.Length == 3)
                {
                    if(people.Contains(person[0]))
                    {
                        Console.WriteLine($"{person[0]} is already in the list!");
                    }
                    else
                    {
                        people.Add(person[0]);
                    }
                }
                else if(person.Length == 4)
                {
                    if(people.Contains(person[0]))
                    {
                        people.Remove(person[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{person[0]} is not in the list!");
                    }
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
