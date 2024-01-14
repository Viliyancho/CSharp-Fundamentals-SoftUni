using System;

namespace _02._CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string first = strings[0];
            string second = strings[1];
            int sum = 0;

            if(first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    sum += first[i] * second[i];
                }
                int difference = first.Length - second.Length;

                for (int j = first.Length - 1; j >= first.Length - difference; j--)
                {
                    sum += first[j];
                }
            }
            else if(second.Length > first.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
                int difference = second.Length - first.Length;

                for (int j = second.Length - 1; j >= second.Length - difference; j--)
                {
                    sum += second[j];
                }
            }
            else
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
