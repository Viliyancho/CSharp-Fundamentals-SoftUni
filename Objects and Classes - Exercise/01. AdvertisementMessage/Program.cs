using System;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string phrases = "";
                string events = "";
                string authors = "";
                string cities = "";

                Random first = new Random();
                int firstNum = first.Next(1, 7);

                Random second = new Random();
                int secondNum = second.Next(1, 7);

                Random third = new Random();
                int thirdNum = third.Next(1, 9);

                Random fourth = new Random();
                int fourthNum = fourth.Next(1, 6);


                Phrases(firstNum, ref phrases);
                Events(secondNum, ref events);
                Authors(thirdNum, ref authors);
                Cities(fourthNum, ref cities);

                Console.WriteLine($"{phrases} {events} {authors} - {cities}.");
            }
        }
        static void Phrases(int firstNum, ref string phrase)
        {
            switch (firstNum)
            {
                case 1:
                    phrase = "Excellent product.";
                    break;
                case 2:
                    phrase = "Such a great product.";
                    break;
                case 3:
                    phrase = "I always use that product.";
                    break;
                case 4:
                    phrase = "Best product of its category.";
                    break;
                case 5:
                    phrase = "Exceptional product.";
                    break;
                case 6:
                    phrase = "I can’t live without this product.";
                    break;
            }
        }

        static void Events(int secondNum, ref string events)
        {
            switch (secondNum)
            {
                case 1:
                    events = "Now I feel good.";
                    break;
                case 2:
                    events = "I have succeeded with this product.";
                    break;
                case 3:
                    events = "Makes miracles. I am happy of the results!";
                    break;
                case 4:
                    events = "I cannot believe but now I feel awesome.";
                    break;
                case 5:
                    events = "Try it yourself, I am very satisfied.";
                    break;
                case 6:
                    events = "I feel great!";
                    break;
            }
        }

        static void Authors(int thirdNum, ref string authors)
        {
            switch (thirdNum)
            {
                case 1:
                    authors = "Diana";
                    break;
                case 2:
                    authors = "Petya";
                    break;
                case 3:
                    authors = "Stella";
                    break;
                case 4:
                    authors = "Elena";
                    break;
                case 5:
                    authors = "Katya";
                    break;
                case 6:
                    authors = "Iva";
                    break;
                case 7:
                    authors = "Annie";
                    break;
                case 8:
                    authors = "Eva";
                    break;
            }
        }

        static void Cities(int fourthNum, ref string cities)
        {
            switch (fourthNum)
            {
                case 1:
                    cities = "Burgas";
                    break;
                case 2:
                    cities = "Sofia";
                    break;
                case 3:
                    cities = "Plovdiv";
                    break;
                case 4:
                    cities = "Varna";
                    break;
                case 5:
                    cities = "Ruse";
                    break;
            }
        }
    }
}
