using System;

namespace _02._PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];

            for (int i = 0; i < array.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());

                array[num - 1] = a;

                num--;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
