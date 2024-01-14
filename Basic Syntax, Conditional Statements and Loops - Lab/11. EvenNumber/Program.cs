using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int place = int.Parse(Console.ReadLine());



            if (place > 10)
            {
                Console.WriteLine($"{num} X {place} = {num * place}");
            }
            else
                {
                while (place <= 10)
                {
                    Console.WriteLine($"{num} X {place} = {num * place}");
                    place++;
                }
            }
        }
    }
}
