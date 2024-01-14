using System;
using System.Text.RegularExpressions;

namespace _02._EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\:\:|\*\*)[A-Z][a-z]{2,}(\1)";
            string pattern1 = @"\d";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            Regex regex1 = new Regex(pattern1);
            MatchCollection matches1 = regex1.Matches(text);

            int threshout = 1;

            
            foreach (Match item in matches1)
            {
                string item1 = item.ToString();
                int number = int.Parse(item1);
                threshout *= number;
            }

            Console.WriteLine($"Cool threshold: {threshout}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match item in matches)
            {
                string str = item.ToString();
                int sum = 0;
                foreach (char item1 in str)
                {
                    if(char.IsLetter(item1))
                    {
                        sum += (int)item1;
                    }
                }

                if(sum >= threshout)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
