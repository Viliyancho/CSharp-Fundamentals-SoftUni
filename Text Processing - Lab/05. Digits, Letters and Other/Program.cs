using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if(char.IsDigit(ch))
                {
                    numbers.Append(ch);
                }
                else if(char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    symbols.Append(ch);
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
