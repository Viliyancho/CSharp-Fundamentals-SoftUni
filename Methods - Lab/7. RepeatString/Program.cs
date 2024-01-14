using System;

namespace _7._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            repeatMethod(input, repeat);
        }
        static void repeatMethod(string input, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(input);
            }
        }
    }
}
