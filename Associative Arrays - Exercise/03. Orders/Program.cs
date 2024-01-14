using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> all = new Dictionary<string, List<double>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "buy")
            {
                string[] coomandArgs = input.Split();
                string name = coomandArgs[0];
                double price = double.Parse(coomandArgs[1]);
                double quantity = double.Parse(coomandArgs[2]);


                if(!all.ContainsKey(name))
                {
                    all.Add(name, new List<double>());
                    all[name].Add(price);
                    all[name].Add(quantity);
                }
                else
                {
                    all[name][0] = price;
                    all[name][1] += quantity;
                }
                
            }
            foreach (var item in all)
            {
                string product = item.Key;
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{product} -> {totalPrice:F2}");
            }
        }
    }
}
