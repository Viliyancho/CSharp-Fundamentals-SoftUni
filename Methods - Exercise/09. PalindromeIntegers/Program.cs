using System;

namespace _09._PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input.Length == 1)
                {
                    Console.WriteLine("true");
                    continue;
                }
                SymmetricalMethod(input);
            }
        }

        private static void SymmetricalMethod(string input)
        {
            int minus = 1;
            for (int i = 0; i < (input.Length) / 2; i++)
            {
                if (input[i] == input[input.Length - minus])
                {
                    if (minus == (input.Length) / 2)
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    minus++;
                    continue;
                }
                else
                {
                    Console.WriteLine("false");
                    break;
                }
            }
        }
    }
}
