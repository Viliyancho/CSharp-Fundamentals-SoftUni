using System;

namespace _06._ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char previousChar = input[0];
            Console.Write(previousChar);
            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i];
                if(previousChar != currentChar)
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);
                }
            }
        }
    }
}
