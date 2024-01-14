using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double studentPrice = 0;
            double businessPrice = 0;
            double regularPrice = 0;

            double totalPrice = 0;

            switch (day)
            {
                case "Friday":
                    studentPrice = 8.45;
                    businessPrice = 10.90;
                    regularPrice = 15;
                    break;
                case "Saturday":
                    studentPrice = 9.80;
                    businessPrice = 15.60;
                    regularPrice = 20;
                    break;
                case "Sunday":
                    studentPrice = 10.46;
                    businessPrice = 16;
                    regularPrice = 22.50;
                    break;
            }

            if (typeOfGroup == "Students")
            {
                totalPrice = count * studentPrice;
            }
            else if (typeOfGroup == "Business")
            {
                totalPrice = count * businessPrice;
            }
            else if (typeOfGroup == "Regular")
            {
                totalPrice = count * regularPrice;
            }

            if (typeOfGroup == "Students" && count >= 30)
            {
                totalPrice *= 0.85;
            }
            if (typeOfGroup == "Business" && count >= 100)
            {
                count -= 10;
            }
            if (typeOfGroup == "Regular" && count >= 10 & count <= 20)
            {
                totalPrice *= 0.95;
            }

           

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
