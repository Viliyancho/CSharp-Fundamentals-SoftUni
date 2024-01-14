using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                pass += currCh;
            }

            for (int i= 3; i > 0; i--)
            {
                string password = Console.ReadLine();
                
                if(password != pass)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (password == pass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
            }

            Console.WriteLine($"User {username} blocked!");
        }
    }
}
