using System;
using System.Linq;

namespace _06._MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            EvenCount(input);
            OddCount(input);
        }
        static void EvenCount (string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write($"{input[input.Length / 2 - 1]}{input[(input.Length / 2)]} ");
            }
        }
        
        static void OddCount (string input)
        {
             if (input.Length % 2 != 0)
            {
                Console.WriteLine($"{input[(input.Length / 2)]}");
            }
        }
    }
}
