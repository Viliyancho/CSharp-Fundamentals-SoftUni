using System;
using System.Linq;
namespace _7._MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int equal = 1;
            int biggestInput = 0;
            int maxNum = int.MinValue;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    equal++;
                    if(equal > maxNum)
                    {
                        maxNum = equal;
                        biggestInput = input[i];
                    }
                }
                else
                {
                    equal = 1;
                }
            }
            for (int i = 0; i < maxNum; i++)
            {
                Console.Write($"{biggestInput} ");
            }
        }
    }
}
