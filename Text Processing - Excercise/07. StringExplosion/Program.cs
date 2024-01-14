using System;

namespace _07._StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bomb = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>' && char.IsDigit(input[i + 1]))
                {
                    bomb += int.Parse(input[i + 1].ToString());
                    if (i == input.LastIndexOf('>') && bomb != 0)
                    {
                        input = input.Remove(i + 1, bomb);
                        break;
                    }
                    else if (bomb != 0)
                    {
                        input = input.Remove(i + 1, 1);
                        bomb--;
                        i--;
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
