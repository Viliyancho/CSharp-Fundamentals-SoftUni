using System;
namespace _8._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine(mathMEthod(a, b));

        }
        static double mathMEthod(double a, double b)
        {
            double result = Math.Pow(a, b);
            return result;
        }
    }
}
