using System;
using System.Collections.Generic;

namespace _06._StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++;
            int c = ++a;
            Console.WriteLine(c);
            Console.WriteLine(b);
        }
    }
}
