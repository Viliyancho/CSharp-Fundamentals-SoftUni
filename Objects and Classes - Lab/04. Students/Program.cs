using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<People> heap = new List<People>();

            while((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input.Split();

                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string town = commandArgs[3];

                People person = new People(firstName, lastName, age, town);
                heap.Add(person);
            }
            string city = Console.ReadLine();

            for (int i = 0; i < heap.Count; i++)
            {
                People example = heap[i];

                if(example.Town == city)
                {
                    Console.WriteLine($"{example.FirstName} {example.LastName} is {example.Age} years old.");
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
