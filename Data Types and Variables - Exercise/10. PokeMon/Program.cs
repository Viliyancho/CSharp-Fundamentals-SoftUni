using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int copyN = n;
            int tries = 0;

            while (copyN >= m)
            {
                copyN -= m;
                tries++;
                if ((double)n / copyN == 2.00 && y != 0)
                {
                    copyN /= y;
                }
            }
            Console.WriteLine(copyN);
            Console.WriteLine(tries);
        }
    }
}
