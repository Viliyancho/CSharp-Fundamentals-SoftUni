using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MergingLists
{
    class Program
    {
        static void Main(string[] args) // 3 5 2 43 12 3 54 10 23   == > 3 76 5 5 2 34 43 2 12 4 3 12 ||| 54 10 23
                                        //76 5 34 2 4 12

        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < Math.Min(numbers1.Count, numbers2.Count); i++)
            {
                Console.Write(numbers1[i] + " " + numbers2[i] + " ");
            }

            if (numbers1.Count > numbers2.Count)
            {
                for (int i = 0; i < numbers2.Count; i++)
                {
                    numbers1.RemoveAt(0);
                }
                Console.WriteLine(string.Join(" ", numbers1));
            }
            else if (numbers1.Count < numbers2.Count)
            {
                for (int i = 0; i < numbers1.Count; i++)
                {
                    numbers2.RemoveAt(0);
                }
                Console.WriteLine(string.Join(" ", numbers2));
            }
        }
    }
}
