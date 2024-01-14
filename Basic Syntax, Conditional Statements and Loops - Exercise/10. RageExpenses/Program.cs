using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine()); ;
            double priceForHeadSet = double.Parse(Console.ReadLine());
            double priceForMouse = double.Parse(Console.ReadLine());
            double priceForKeyboard = double.Parse(Console.ReadLine());
            double priceForDispaly = double.Parse(Console.ReadLine());

            double sum = 0;

            int countHeadSet = lostGames / 2;
            int countMouse = lostGames / 3;
            int countKeyboard = lostGames / 6;
            int countDisplay = lostGames / 12;

            sum = priceForHeadSet * countHeadSet + priceForMouse * countMouse + priceForKeyboard * countKeyboard + priceForDispaly * countDisplay;
            Console.WriteLine($"Rage expenses: {sum:F2} lv.");
        }
    }
}
