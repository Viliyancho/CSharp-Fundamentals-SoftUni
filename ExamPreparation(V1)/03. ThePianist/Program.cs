using System;
using System.Collections.Generic;

namespace _03._ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> all = new Dictionary<string, string[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] commandArgs = input.Split('|');
                string piece = commandArgs[0];
                string composer = commandArgs[1];
                string key = commandArgs[2];
                all.Add(piece, new string[2]);
                all[piece][0] = composer;
                all[piece][1] = key;
            }

            string input1 = string.Empty;

            while((input1 = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs1 = input1.Split('|');

                string command = commandArgs1[0];
                string piece = commandArgs1[1];
                if(command == "Add")
                {
                    string composer = commandArgs1[2];
                    string key = commandArgs1[3];
                    if(all.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        all.AD(piece, new string[2]);
                        all[piece][0] = composer;
                        all[piece][1] = key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if(command == "Remove")
                {
                    if(all.ContainsKey(piece))
                    {
                        all.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if(command == "ChangeKey")
                {
                    if (all.ContainsKey(piece))
                    {
                        string key = commandArgs1[2];
                        all[piece][1] = key;
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var item in all)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }

        }
    }
}
