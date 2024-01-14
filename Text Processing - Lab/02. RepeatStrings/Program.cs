using System;

namespace _02._RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
