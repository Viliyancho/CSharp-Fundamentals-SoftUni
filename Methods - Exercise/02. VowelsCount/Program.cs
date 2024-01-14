using System;
using System.Linq;

namespace _02._VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
        }
        static int VowelsCount(string input)
        {
            int count = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (char symbol in input.ToLower())
            {
                if (vowels.Contains(symbol))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
