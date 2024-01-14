using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();
            while(true)
            {
                if (text.Contains(key))
                {
                    int a = text.IndexOf(key);
                    int b = key.Length;
                    text = text.Remove(a, b);
                }
                else
                {
                    Console.WriteLine(text);
                    return;
                }
            }
        }
    }
}
