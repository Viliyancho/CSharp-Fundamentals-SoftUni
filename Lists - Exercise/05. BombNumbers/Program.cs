using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            List<int> arguments = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            int count = 0;

            int bomb = arguments[0];
            int radius = arguments[1];

            foreach (var item in numbers)
            {
                if(item == bomb)
                {
                    count++;
                }
            }

            for (int j = 0; j < count; j++)
            {
                for (int i = 1; i <= radius; i++)
                {
                    if ((numbers.IndexOf(bomb) - 1) >= 0)
                    {
                        if (numbers[numbers.IndexOf(bomb) - 1] == bomb)
                        {
                            count--;
                        }
                    }

                    if ((numbers.IndexOf(bomb) + 1 < numbers.Count))
                    {
                        if (numbers[numbers.IndexOf(bomb) + 1] == bomb)
                        {
                            count--;
                        }
                    }

                    if((numbers.IndexOf(bomb) - 1) >=0 && (numbers.IndexOf(bomb) - 1) < numbers.Count)
                    {
                        numbers.RemoveAt(numbers.IndexOf(bomb) - 1);
                    }
                    if ((numbers.IndexOf(bomb) + 1) >= 0 && (numbers.IndexOf(bomb) + 1) < numbers.Count)
                    {
                        numbers.RemoveAt(numbers.IndexOf(bomb) + 1);
                    }
                }
                numbers.Remove(bomb);
            }


            int sum = numbers.Sum();
            Console.WriteLine(sum);
            
        }
    }
}
