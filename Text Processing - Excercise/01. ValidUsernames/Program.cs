using System;

namespace _01._ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] input = text.Split(", ");
            foreach (var item in input)
            {
                if(item.Length > 3 && item.Length < 16)
                {
                    bool isTrue = true;
                    foreach (char ch in item)
                    {
                        if(!(char.IsDigit(ch) || char.IsLetter(ch) || ch == '-' || ch == '_'))
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    if(isTrue)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
