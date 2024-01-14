using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            method(input, n1, n2);
        }
        static void method(string input, int n1, int n2)
        {
            switch(input)
                {
                case "add":
                    Console.WriteLine(n1 + n2);
                    break;
                case "multiply":
                    Console.WriteLine(n1 * n2);
                    break;
                case "substract":
                    Console.WriteLine(n1 - n2);
                    break;
                case "divide":
                    Console.WriteLine(n1 / n2);
                    break;

            }

        }
    }
}
