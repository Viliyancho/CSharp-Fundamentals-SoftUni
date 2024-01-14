using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> all = new List<Person>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(commandArgs);
                all.Add(person);
            }

            var newList = all.OrderBy(x => x.Age);
            foreach (var item in newList)
            {
                Console.WriteLine(string.Join(Environment.NewLine, item.ToString()));
            }
        }
    }
    public class Person
    {
        public Person(string[] commandArgs)
        {
            Name = commandArgs[0];
            ID = commandArgs[1];
            Age = int.Parse(commandArgs[2]);
        }
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}