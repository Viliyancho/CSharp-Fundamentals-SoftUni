using System;
using System.Linq;
namespace _08._CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int finalResult = 0;
            for (int i = 0; i < input1.Length - 1; i++)
            {
                int[] input2 = new int[input1.Length - 1];
                for (int j = 0; j < input1.Length - 2; j++)
                {
                    input2[j] = input1[i] + input1[i + 1];
                    finalResult += input2[j];
                }
            }

            for (int k = 0; k < input1.Length - 3; k++)
            {
                finalResult += input2[k] + input2[k + 1];
            }
            Console.WriteLine(finalResult);
        }
    }
}
