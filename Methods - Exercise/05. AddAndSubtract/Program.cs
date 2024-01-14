using System;

namespace _05._AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result1 = AddMethod(a, b);
            Console.WriteLine(SubstractMethod(result1, c));
        }
        static int AddMethod(int a, int b)
        {
            return a + b;
        }

        static int SubstractMethod(int result1, int c)
        {
            return  result1- c;
        }
    }
}
