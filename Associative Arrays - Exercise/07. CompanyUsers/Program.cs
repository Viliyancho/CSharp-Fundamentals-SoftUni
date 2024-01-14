using System;
using System.Collections.Generic;

namespace _07._CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> all = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = commandArgs[0];
                string employes = commandArgs[1];
                if (!all.ContainsKey(company))
                {
                    all.Add(company, new List<string>());
                }
                if(!all[company].Contains(employes))
                {
                    all[company].Add(employes);
                }
            }

            foreach (var company in all)
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
