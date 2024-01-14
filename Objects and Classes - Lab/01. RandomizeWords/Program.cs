using System;

namespace _01._RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split();

            for (int i = 0; i < sentence.Length; i++)
            {
                Random random = new Random();
                int number = random.Next(0, sentence.Length);
                string first = sentence[i];

                sentence[i] = sentence[number];
                sentence[number] = first;
            }

            Console.WriteLine(string.Join(Environment.NewLine, sentence));
        }
    }
}
