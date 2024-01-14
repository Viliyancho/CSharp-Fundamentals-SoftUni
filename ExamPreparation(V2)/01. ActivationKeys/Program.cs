using System;
using System.Text;

namespace _01._ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder key = new StringBuilder(Console.ReadLine());

            string input = string.Empty;
            while((input = Console.ReadLine()) != "Generate")
            {
                string[] commandArgs = input.Split(">>>");
                string name = commandArgs[0];

                if(name == "Contains")
                {
                    string substring = commandArgs[1];
                    if (key.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if(name == "Flip")
                {
                    string textType = commandArgs[1];
                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);

                    string sub = key.ToString().Substring(startIndex, endIndex - startIndex);

                    key.Remove(startIndex, endIndex - startIndex);

                    if(textType == "Upper")
                    {
                        sub = sub.ToUpper();
                    }
                    else if(textType == "Lower")
                    {
                        sub = sub.ToLower();
                    }
                    key.Insert(startIndex, sub);
                    Console.WriteLine(key);
                }
                else if(name == "Slice")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }
            }

            Console.WriteLine($"Your activation key is: {key}");

        }
    }
}
