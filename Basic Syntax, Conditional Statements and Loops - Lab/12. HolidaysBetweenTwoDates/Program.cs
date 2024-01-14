using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");
                    num = int.Parse(Console.ReadLine());
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }
            }
        }
    }
}
