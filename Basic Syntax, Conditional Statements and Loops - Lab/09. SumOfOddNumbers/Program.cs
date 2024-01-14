using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; count > 0; i += 2)
            {
                sum += i;
                Console.WriteLine(i);
                count--;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
