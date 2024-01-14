using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss_Trick
{
    class Program
    {
        static void Main(string[] args) // 1 2 3 4 5 == 6 6 3
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int z = numbers.Count;

            for (int i = 0; i < z / 2; i++)
            {
                numbers[i] += numbers[z - 1 - i];
                numbers.Remove(numbers[z - 1 - i]);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
