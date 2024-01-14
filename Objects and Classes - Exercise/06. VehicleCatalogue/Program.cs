using System;
using System.Collections.Generic;

namespace _06._VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> all = new List<Car>();    
            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" ");
                Car car = new Car(commandArgs);
                all.Add(car);
            }

            string mark = string.Empty;
            while((mark = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var item in all)
                {
                    if(item.Mark == mark)
                    {
                        Console.WriteLine($"Type: {char.ToUpper(item.Type[0]) + item.Type.Substring(1)}");
                        Console.WriteLine($"Model: {item.Mark}");
                        Console.WriteLine($"Color: {item.Colour}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                        break;
                    }
                }
            }
            double carsAverage = 0;
            int carsCount = 0;

            double trucksAverage = 0;
            int trucksCount = 0;
            foreach (var item in all)
            {
                if(item.Type == "car")
                {
                    carsAverage += item.HorsePower;
                    carsCount++;
                }
                else if(item.Type == "truck")
                {
                    trucksAverage += item.HorsePower;
                    trucksCount++;
                }
            }

            carsAverage /= carsCount;
            trucksAverage /= trucksCount;

            Console.WriteLine($"Cars have average horsepower of: {carsAverage:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:F2}.");
        }
    }
    public class Car
    {
        public Car(string[] commandArgs)
        {
            Type = commandArgs[0];
            Mark = commandArgs[1];
            Colour = commandArgs[2];
            HorsePower = int.Parse(commandArgs[3]);
        }
    public string Type { get; set; }
    public string Mark { get; set; }
    public string Colour { get; set; }
    public int HorsePower { get; set; }
    }
}
//Don't work