using System;

namespace _01._DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int num = int.Parse(Console.ReadLine());

            if(num < 1 || num > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[num - 1]);
            }
        }
    }
}
