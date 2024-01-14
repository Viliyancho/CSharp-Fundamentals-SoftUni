using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;
            
            while (input != "Start")
            {
                decimal coins = decimal.Parse(input);
                if (coins == 0.1m)
                {
                    sum += coins;
                }
                else if (coins == 0.2m)
                {
                    sum += coins;
                }
                else if (coins == 0.5m)
                {
                    sum += coins;
                }
                else if (coins == 1m)
                {
                    sum += coins;
                }
                else if (coins == 2m)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sum >= 2.0m)
                        {
                            sum -= 2.0m;
                            Console.WriteLine($"Purchased {product.ToLower()}");

                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;

                    case "Water":
                        if (sum >= 0.7m)
                        {
                            sum -= 0.7m;
                            Console.WriteLine($"Purchased {product.ToLower()}");

                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;

                    case "Crisps":
                        if (sum >= 1.5m)
                        {
                            sum -= 1.5m;
                            Console.WriteLine($"Purchased {product.ToLower()}");

                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;

                    case "Soda":
                        if (sum >= 0.8m)
                        {
                            sum -= 0.8m;
                            Console.WriteLine($"Purchased {product.ToLower()}");

                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;

                    case "Coke":
                        if (sum >= 1.0m)
                        {
                            sum -= 1.0m;
                            Console.WriteLine($"Purchased {product.ToLower()}");

                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();

            }

            Console.WriteLine($"Change: {sum:F2}");

        }
    }
}
