using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            switchMethod(product, count);
        }
        static void switchMethod(string product, int count)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{(1.50 * count):F2}");
                    break;
                case "water":
                    Console.WriteLine($"{(1.00 * count):F2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(1.40 * count):F2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(2.00 * count):F2}");
                    break;
            }

        }
    }
}
