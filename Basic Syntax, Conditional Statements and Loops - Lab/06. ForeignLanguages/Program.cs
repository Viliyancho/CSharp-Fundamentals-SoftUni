using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = Console.ReadLine();

            switch(language)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
