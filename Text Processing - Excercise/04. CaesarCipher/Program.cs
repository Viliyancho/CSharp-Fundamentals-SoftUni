using System;

namespace _04._CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var item in input)
            {
                int number = (int)item + 3;
                char symbol = (char)number;
                Console.Write(symbol);
            }
        }
    }
}
