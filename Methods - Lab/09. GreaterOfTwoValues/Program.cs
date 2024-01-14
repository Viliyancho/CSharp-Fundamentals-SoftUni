using System;

namespace _09._GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if(input == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(stringMethod(a,b));
            }
            else if(input == "int")
            {
                int int1 = int.Parse(Console.ReadLine());
                int int2 = int.Parse(Console.ReadLine());
                Console.WriteLine(intMethod(int1, int2));
            }
            else if (input == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(charMethod(firstChar, secondChar));
            }
        }


        static string stringMethod(string a, string b)
        {
            int result1 = 0;
            int result2 = 0;
            string bigger = string.Empty;

            foreach (char c in a)
            {
                result1 += (int)c;
            }
            foreach (char c in b)
            {
                result2 += (int)c;
            }

            if(result1 > result2)
            {
                bigger = a;
            }
            else if (result2 > result1)
            {
                bigger = b;
            }
            return bigger;
        }

        static int intMethod(int int1, int int2)
        {
            int bigger1 = 0;
            if(int1 > int2)
            {
                bigger1 = int1;
            }
            else if (int2 > int1)
            {
                bigger1 = int2;
            }
            return bigger1;
        }

        static char charMethod(char firstChar, char secondChar)
        {
            char bigger2 = ' ';
            if (firstChar > secondChar)
            {
                bigger2 = (char)firstChar;
            }
            else if (secondChar > firstChar)
            {
                bigger2 = (char)secondChar;
            }
            return bigger2;
        }
    }
}
