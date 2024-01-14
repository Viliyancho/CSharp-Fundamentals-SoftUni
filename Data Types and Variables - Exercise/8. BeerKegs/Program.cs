using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            double volume = 0;
            string theKeg = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > biggestKeg)
                {
                    theKeg = name;
                    biggestKeg = volume;
                }
            }
            Console.WriteLine(theKeg);
        }
    }
}
