using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            List<int> player2 = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            while (player1.Count != 0 && player2.Count != 0)
            {
                    if(player1[0] > player2[0])
                    {
                        player1.Add(player1[0]);
                        player1.Add(player2[0]);
                        player1.RemoveAt(0);
                        player2.RemoveAt(0);
                    }
                    else if (player2[0] > player1[0])
                    {
                        player2.Add(player2[0]);
                        player2.Add(player1[0]);
                        player1.RemoveAt(0);
                        player2.RemoveAt(0);
                    }
                    else if (player2[0] == player1[0])
                    {
                        player1.RemoveAt(0);
                        player2.RemoveAt(0);
                    }
                
            }

            if(player1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
            }
            else if (player2.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            }
        }
    }
}
