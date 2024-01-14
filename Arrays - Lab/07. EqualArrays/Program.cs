using System;
using System.Linq;
namespace _07._EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int difference = 0;
            int index = 0;

            if (input1.Length == input2.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] != input2[i])
                    {
                        index = i;
                        difference++;
                        break;
                    }
                    else
                    {
                        sum += input1[i];
                    }
                }
            }
            else
            {
                return;
            }

            if(difference == 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
