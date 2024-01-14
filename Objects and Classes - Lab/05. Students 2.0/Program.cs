using System;
using System.Collections.Generic;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<People> heap = new List<People>();

            while((input = Console.ReadLine()) != "end")
            {
                bool check = false;
                string[] commandArgs = input.Split();

                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string town = commandArgs[3];

                for (int i = 0; i < heap.Count; i++)
                {
                    People example = heap[i];
                    if (example.FirstName == firstName && example.LastName == lastName)
                    {
                        example.Town = town;
                        example.Age = age;
                        check = true;
                    }
                }
                if(!check)
                {
                    People person = new People(firstName, lastName, age, town);
                    heap.Add(person);
                }
            }

            string city = Console.ReadLine();

            for (int i = 0; i < heap.Count; i++)
            {
                People one = heap[i];
                if(city == one.Town)
                {
                    Console.WriteLine($"{one.FirstName} {one.LastName} is {one.Age} years old.");
                }
            }
        }
    }
    public class People
    {

        public People(string first, string last, int age, string town)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }
    }
}
