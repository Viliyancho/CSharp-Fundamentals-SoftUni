using System;

namespace _01._SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            ifMethod(number);
        }
        static void ifMethod(int number)
        {
            if(number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
