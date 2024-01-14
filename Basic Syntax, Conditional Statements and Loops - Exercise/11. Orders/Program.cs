using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            decimal totalSum = 0;
            for (int i = 1; i <= people; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                decimal sum = price * days * count;
                totalSum += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:F2}");
            }
            Console.WriteLine($"Total: ${totalSum:F2}");
        }
    }
}
