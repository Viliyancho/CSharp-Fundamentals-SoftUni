using System;
using System.Text;

namespace _01._SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder secretMessage = new StringBuilder(Console.ReadLine());

            string input = string.Empty;
            while((input = Console.ReadLine()) != "Reveal")
            {
                string[] commandArgs = input.Split(":|:");
                string command = commandArgs[0];
                if(command == "InsertSpace")
                {
                    
                    int index = int.Parse(commandArgs[1]);
                    secretMessage.Insert(index, ' ');
                    Console.WriteLine(secretMessage);
                }
                else if(command == "Reverse")
                {
                    string substring = commandArgs[1];
                    if(!secretMessage.ToString().Contains(substring))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        int index1 = secretMessage.ToString().IndexOf(substring);
                        secretMessage.Remove(index1, substring.Length);
                        string a = "";
                        foreach (char item in substring)
                        {
                            a = a.Insert(0,item.ToString());
                        }
                        secretMessage.Append(a);
                        Console.WriteLine(secretMessage);
                    }
                }
                else if(command == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    secretMessage.Replace(substring, replacement);
                    Console.WriteLine(secretMessage);
                }

            }

            Console.WriteLine($"You have a new text message: {secretMessage}");
        }
    }
}
