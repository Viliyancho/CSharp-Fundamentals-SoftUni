using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                string newString = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    newString = newString + input[i];
                }
                Console.WriteLine($"{input} = {newString}");
            }
        }
    }
}
