using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            int a = int.Parse(Console.ReadLine());
            string pattern = @"^[^\@|\-|\:|\!|\>]*?@(?<name>[A-Za-z]+)[^\@|\-|\:|\!|\>]*?:[0-9]+[^\@|\-|\:|\!|\>]*?!(?<attackType>[A|D]{1})![^\@|\-|\:|\!|\>]*?->[0-9]+[^\@|\-|\:|\!|\>]*?$";
            Regex regex = new Regex(pattern);

            int attackedPlanets = 0;
            int destroyedPlanets = 0;

            for (int i = 0; i < a; i++)
            {
                StringBuilder messageCopy = new StringBuilder();
                string input = Console.ReadLine();
                int count = 0;

                foreach (char item in input.ToLower())
                {
                    if(item == 's' || item == 't' || item == 'a' || item == 'r')
                    {
                        count++;
                    }
                }

                foreach (char item1 in input)
                {
                    int b = (int)item1 - count;
                    messageCopy.Append((char)b);
                }

                string message = messageCopy.ToString();

                Match match = regex.Match(message);

                if(match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if(attackType == "A")
                    {
                        attackedPlanets++;
                        attacked.Add(name);
                    }
                    else if(attackType == "D")
                    {
                        destroyedPlanets++;
                        destroyed.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets}");
            foreach (var item in attacked.OrderBy(p => p))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets}");
            foreach (var item in destroyed.OrderBy(p => p))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
