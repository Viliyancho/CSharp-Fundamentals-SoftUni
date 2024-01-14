using System;

namespace _10._TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if(HasOddDigit(i) && DivisibleBy8(i))
                {
                    Console.WriteLine(i);
                }
            }


            static bool HasOddDigit(int i)
            {
                while (i > 0)
                {
                    if ((i % 10) % 2 != 0)
                    {
                        return true;
                    }
                    i /= 10;
                }
                return false;
            }

            static bool DivisibleBy8(int i)
            {
                int sum = 0;
                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                if (sum % 8 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
