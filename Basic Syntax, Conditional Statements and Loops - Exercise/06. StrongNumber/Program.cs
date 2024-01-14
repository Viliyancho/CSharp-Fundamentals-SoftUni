using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copyNum = num;
            int sum = 0;
            int factorial = 1;
            while(copyNum > 0)
            {
                int lastDigit = copyNum % 10;

                if (lastDigit == 0)
                {
                    sum++;
                    lastDigit = 1;
                    copyNum /= 10;
                    continue;
                }

                for (int i = lastDigit; i > 0; i--)
                {
        
                    
                    factorial *= i;
                }
                
                copyNum /= 10;
                sum += factorial;
                factorial = 1;
            }

            if ( sum == num)
            {
                Console.WriteLine("yes");
            }    
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
