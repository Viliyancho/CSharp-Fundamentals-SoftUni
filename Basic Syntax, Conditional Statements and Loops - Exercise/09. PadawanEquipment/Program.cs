using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double countLightSaber = count + Math.Ceiling(0.1*count);
            double countRobes = count;
            int countBelts = count;

            int freeBelts = countBelts / 6;
            countBelts -= freeBelts;

            double sum = priceLightsaber * countLightSaber + priceRobes * countRobes + priceBelts * countBelts;

            if(money >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs((sum - money)):F2}lv more.");
            }
        }
    }
}
