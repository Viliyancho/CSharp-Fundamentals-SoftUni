using System;

namespace _7.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pouring = 0;
            int capacity = 255;

            for (int i = 0; i < n; i++)
            {
                int liter = int.Parse(Console.ReadLine());
                if (pouring + liter > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    pouring += liter;
                }
            }
            Console.WriteLine(pouring);
        }
    }
}
