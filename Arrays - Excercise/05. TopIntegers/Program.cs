using System;
using System.Linq;
namespace _05._TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int maxNum = int.MinValue;


            for (int i = 0; i < input.Length; i++)
            {

                for (int j = i + 1; j < input.Length; j++)
                {
                    maxNum = int.MinValue;
                    if(input[i]>input[j])
                    {
                        maxNum = input[i];
                    }
                    else if(input[i] < input[j])
                    {
                        break;
                    }
                }

                if(maxNum == input[i])
                {
                    Console.Write($"{input[i]} ");
                }
            }

            Console.WriteLine(input[input.Length - 1]);
        }
    }
}
