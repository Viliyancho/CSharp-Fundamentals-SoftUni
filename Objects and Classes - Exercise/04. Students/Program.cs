using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> all = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(commandArgs);
                all.Add(student);
            }

            var newList = all.OrderByDescending(x => x.Grade);
            foreach (var item in newList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    public class Student
    {
        public Student(string[] command)
        {
            FirstName = command[0];
            LastName = command[1];
            Grade = double.Parse(command[2]);
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
