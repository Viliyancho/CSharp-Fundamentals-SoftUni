using System;

namespace _03._CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            ForCycle(a, b);
        }
        static void ForCycle(char a, char b)
        {
            if (a > b)
            {
                for (int i = (int)b + 1; i < (int)a; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else if (b > a)
            {
                for (int i = (int)a + 1; i < (int)b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
