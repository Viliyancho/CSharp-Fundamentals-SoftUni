using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"[A-Za-z]";
            string patternKM = @"[0-9]";

            Dictionary<string, int> people = new Dictionary<string, int>();
            List<string> names = Console.ReadLine().Split(", ").ToList();

            foreach (var item in names)
            {
                people.Add(item, 0);
            }

            Regex regexName = new Regex(patternName);
            Regex regexKM = new Regex(patternKM);

            string input = string.Empty;


            while((input = Console.ReadLine()) != "end of race")
            {
                int kilometres = 0;

                MatchCollection matchName = regexName.Matches(input);
                MatchCollection matchKM = regexKM.Matches(input);

                StringBuilder name = new StringBuilder();

                if(matchName.Count != 0)
                {
                    foreach (Match item1 in matchName)
                    {
                        name.Append(item1);
                    }
                }
                
                if(matchKM.Count != 0)
                {
                    foreach (Match item2 in matchKM)
                    {
                        string a = item2.ToString();
                        int b = int.Parse(a);
                        kilometres += b;
                    }
                }
                

                string name1 = name.ToString();
                if (people.ContainsKey(name1))
                {
                    people[name1] += kilometres;
                }
            }
            int i = 3;
            foreach (var item in people.OrderByDescending(p=>p.Value))
            {
                if (i == 3)
                Console.WriteLine($"1st place: {item.Key}");
                else if(i == 2)
                    Console.WriteLine($"2nd place: {item.Key}");
                else if(i == 1)
                    Console.WriteLine($"3rd place: {item.Key}");
                else if (i == 0)
                    return;

                i--;
            }
        }
    }
}
