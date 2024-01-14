using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> words = new Dictionary<char, int>();
            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char ch = item[i];
                    if(!words.ContainsKey(ch))
                    {
                        words.Add(ch, 0);
                    }
                    words[ch]++;
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
