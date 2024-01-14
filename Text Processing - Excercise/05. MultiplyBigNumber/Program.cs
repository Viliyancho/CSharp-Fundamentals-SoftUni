using System;
using System.Collections.Generic;

namespace _05._MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sum = new List<int>();
            string num = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            int remainder;
            int difference = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                int digit = num[i] - '0';
                int firstSum = digit * times;
                if(firstSum> 10)
                {
                     remainder = firstSum % 10;
                }
                else
                {
                    remainder = firstSum;
                }
                remainder += difference;
                difference += firstSum / 10;
                if(remainder > 10)
                {
                    difference += remainder / 10;
                    remainder %= 10;
                    sum.Insert(0, remainder);
                }
                else
                {
                    sum.Insert(0, remainder);
                }
            }
            foreach (var item in sum)
            {
                Console.Write(item);
            }
        }
    }
}
