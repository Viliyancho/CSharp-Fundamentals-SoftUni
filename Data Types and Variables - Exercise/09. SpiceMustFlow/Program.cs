using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = int.Parse(Console.ReadLine());
            int remain = 0;
            int days = 0;

            while (product >= 100)
            {
                days++;
                remain += product;
                remain -= 26;
                product -= 10;
            }
            if(remain != 0)
            {
                remain -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(remain);
        }
    }
}
