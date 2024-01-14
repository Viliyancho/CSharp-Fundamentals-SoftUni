using System;

namespace _03._ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split("\\");
            string[] last = file[file.Length - 1].Split(".");
            string name = last[0];
            string extension = last[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
