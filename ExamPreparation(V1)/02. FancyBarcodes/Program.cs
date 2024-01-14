using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = @"@(\#+)[A-Z][A-Za-z0-9]{4,}[A-Z]@(\#+)";
            string pattern2 = @"[0-9]";
            Regex regex = new Regex(pattern1);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                StringBuilder barcode = new StringBuilder();

                string code = Console.ReadLine();
                Match match = regex.Match(code);
                if(!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    Regex regex1 = new Regex(pattern2);
                    MatchCollection matches = regex1.Matches(match.ToString());
                    
                    foreach (Match item in matches)
                    {
                        barcode.Append(item.ToString());
                    }

                    if (barcode.Length != 0)
                    {
                        Console.WriteLine($"Product group: {barcode}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                
            }
        }
    }
}
