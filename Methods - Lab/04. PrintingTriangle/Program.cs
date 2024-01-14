using System;

namespace _04._PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            forMethod(n);
        }
        static void forMethod(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int k = n - 1; k >= 0; k--)
            {
                for (int h = 1; h <= k; h++)
                {
                    Console.Write(h + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
