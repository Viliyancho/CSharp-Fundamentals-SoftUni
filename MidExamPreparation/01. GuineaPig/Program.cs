using System;

namespace _01._GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal weight = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                if(food > 0.3m && hay > 0.05m * food && cover > weight / 3.0m)
                {
                    food -= 0.3m;
                    if (i % 2 == 0)
                    {
                            hay -= 0.05m * food;
                    }
                    if (i % 3 == 0)
                    {
                            cover -= weight / 3.0m;
                    }
                }
                else
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                

            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
        }
    }
}
