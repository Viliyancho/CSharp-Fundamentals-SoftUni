using System;
using System.Text.RegularExpressions;

namespace _03.__SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\|\$\.\%]*?%(?<name>[A-Z][a-z]+)%[^\|\$\.\%]*?<(?<product>\w+)>[^\|\$\.\%]*?\|(?<count>\d+)\|[^\|\$\.\%]*?(?<price>\d+(\.\d+)?)\$[^\|\$\.\%]*?$";
            Regex regex = new Regex(pattern);
            string input = string.Empty;
            double totalPrice = 0;

            while((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if(match.Success)
                {
                    double finalPrice = 0;
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    finalPrice = price * count;
                    totalPrice += finalPrice;
                    Console.WriteLine($"{name}: {product} - {finalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
