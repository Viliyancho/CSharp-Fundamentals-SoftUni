using System;

namespace _6._CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(areaMethod(a, b));
        }
        static double areaMethod(double a, double b)
        {
            return a * b;
        }
    }
}
