using System;

namespace _04._TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var item in input)
            {
                if(text.Contains(item))
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
