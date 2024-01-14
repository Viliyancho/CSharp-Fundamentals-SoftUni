using System;

namespace _01._SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(FirstOne(a, b), c));
        }
        static int FirstOne(int a, int b)
        {
            return Math.Min(a, b);
        }
    }
}
