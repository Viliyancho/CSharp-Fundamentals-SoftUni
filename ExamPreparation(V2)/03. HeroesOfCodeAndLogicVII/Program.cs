using System;
using System.Collections.Generic;

namespace _03._HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] hero = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = hero[0];
                int hp = int.Parse(hero[1]);
                int mana = int.Parse(hero[2]);
                heroes.Add(name, new int[2]);
                heroes[name][0] = hp;
                heroes[name][1] = mana;
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" - ");
                string command = commandArgs[0];
                string name = commandArgs[1];

                if (command == "CastSpell")
                {
                    int neededMana = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (heroes[name][1] >= neededMana)
                    {
                        heroes[name][1] -= neededMana;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(commandArgs[2]);
                    string attackerName = commandArgs[3];

                    if (damage >= heroes[name][0])
                    {
                        Console.WriteLine($"{name} has been killed by {attackerName}!");
                        heroes.Remove(name);
                    }
                    else
                    {
                        heroes[name][0] -= damage;
                        Console.WriteLine($"{name} was hit for {damage} HP by {attackerName} and now has {heroes[name][0]} HP left!");
                    }
                }
                else if(command == "Recharge")
                {
                    int manaGain = int.Parse(commandArgs[2]);
                    int possibleGain = 0;
                    if(heroes[name][1] + manaGain > 200)
                    {
                        possibleGain = 200 - heroes[name][1];
                        heroes[name][1] = 200;
                    }
                    else
                    {
                        possibleGain = manaGain;
                        heroes[name][1] += possibleGain;
                    }
                    Console.WriteLine($"{name} recharged for {possibleGain} MP!");
                }
                else if(command == "Heal")
                {
                    int hpGain = int.Parse(commandArgs[2]);
                    int possibleGain = 0;
                    if(heroes[name][0] + hpGain > 100)
                    {
                        possibleGain = 100 - heroes[name][0];
                        heroes[name][0] = 100;
                    }
                    else
                    {
                        possibleGain = hpGain;
                        heroes[name][0] += possibleGain;
                    }
                    Console.WriteLine($"{name} healed for {possibleGain} HP!");
                }
            }
            foreach (var item in heroes)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }
        }
    }
}
