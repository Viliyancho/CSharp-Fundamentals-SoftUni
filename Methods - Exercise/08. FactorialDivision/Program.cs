using System;

namespace _08._FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            decimal result = Factorial1(a) / Factorial2(b);

            Console.WriteLine($"{result:f2}");
        }

        private static decimal Factorial2(int b)
        {
            decimal sum2 = 1;
            for (int i = 1; i <= b; i++)
            {
                sum2 *= i;
            }
            return sum2;
        }

        private static decimal Factorial1(int a)
        {
            decimal sum1 = 1;
            for (int i = 1; i <= a; i++)
            {
                sum1 *= i;
            }
            return sum1;
        }
    }
}
