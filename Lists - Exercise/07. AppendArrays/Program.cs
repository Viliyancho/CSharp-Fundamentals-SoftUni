using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> final = new List<int>();
            string[] arrInArr = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            foreach (var item in arrInArr)
            {
                final.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", final));
        }
    }
}
