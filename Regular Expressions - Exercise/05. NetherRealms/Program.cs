using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> all = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();
            string[] aliens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string pattern1 = @"[^\d|\+|\-|\*|\//|\.]";
            string pattern2 = @"([(\-)?0-9]{1,2}(\.\d+)*?)|[\/|\*]";
            Regex regex1 = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);

            for (int i = 0; i < aliens.Length; i++)
            {
                MatchCollection matches1 = regex1.Matches(aliens[i]);
                MatchCollection matches2 = regex2.Matches(aliens[i]);
                int health = 0;
                double damage = 0;

                int count1 = 0;
                int count2 = 0;

                foreach (Match item in matches1)
                {
                    string zz = item.ToString();
                    char ch = char.Parse(zz);
                    health += (int)ch;
                }

                foreach (Match item 
                    in matches2)
                {
                    string number = item.ToString();
                    if (number == "/")
                    {
                        count1++;
                    }
                    else if(number == "*")
                    {
                        count2++;
                    }
                    else
                    {
                        
                        int number1 = int.Parse(number);
                        damage += number1;
                    }
                }

                for (int j = 0; j < count1; j++)
                {
                    damage /= 2;
                }
                for (int k = 0; k < count2; k++)
                {
                    damage *= 2;
                }
                all.Add(aliens[i], new List<double>());
                all[aliens[i]].Add(health);
                all[aliens[i]].Add(damage);
            }

            foreach (var item in all.OrderBy(p=>p.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }
           
        }
    }
}
