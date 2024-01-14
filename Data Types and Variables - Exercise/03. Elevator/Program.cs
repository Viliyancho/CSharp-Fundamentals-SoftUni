using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)people / capacity;

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
