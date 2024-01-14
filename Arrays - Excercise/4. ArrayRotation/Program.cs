using System;
using System.Linq;
namespace _4._ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int firstNum = 0;

            while (rotations > 0)
            {
                firstNum = arr1[0];
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    arr1[i] = arr1[i + 1];
                }
                arr1[arr1.Length - 1] = firstNum;
                rotations--;
            }
            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}
