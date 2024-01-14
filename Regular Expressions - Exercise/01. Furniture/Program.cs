using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            string pattern = @"^>>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+(\.\d+)?)$";

            Regex regex = new Regex(pattern);
            string input = string.Empty;
            double price = 0;

            while((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string currName = match.Groups["name"].Value;
                    names.Add(currName); // first step

                    double currPrice = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);

                    currPrice *= (int)quantity;
                    price += currPrice;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}
