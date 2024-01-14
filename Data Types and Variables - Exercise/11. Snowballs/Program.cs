using System;

namespace _11.Snowballs
{

    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            int maxSnowBallSnow = 0;
            int maxSnowBallTime = 0;
            int maxSnowBallQuality = 0;
            BigInteger maxSnowBallValue = 0;

            BigInteger max = BigInteger.MinusOne;

            for (int i = 0; i < n; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger sum = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (sum > max)
                {
                    max = sum;
                    maxSnowBallSnow = snowBallSnow;
                    maxSnowBallTime = snowBallTime;
                    maxSnowBallQuality = snowBallQuality;
                    maxSnowBallValue = max;
                }
            }
            Console.WriteLine($"{maxSnowBallSnow} : {maxSnowBallTime} = {maxSnowBallValue} ({maxSnowBallQuality})");
            
        }
    }
}
