using System;
using System.Collections.Generic;

namespace _02._OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> all = new Dictionary<string, int>();

            string[] words = Console.ReadLine().Split();

            foreach (var item in words)
            {
                string word = item.ToLower();
                if(!all.ContainsKey(word))
                {
                    all.Add(word, 0);
                }
                all[word]++;
            }

            foreach (var item in all)
            {
                if(item.Value % 2 == 1)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
