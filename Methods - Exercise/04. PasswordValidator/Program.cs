using System;

namespace _04._PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool a = CharacterContains(password);
            bool b = LetterAndDigits(password);
            bool c = AtLeastTwoDigits(password);

            if (a && b && c)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CharacterContains(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }

        static bool LetterAndDigits(string password)
        {
            foreach (char ch in password)
            {
                if (Char.IsLetterOrDigit(ch))
                {
                    continue;
                }
                else if (!Char.IsLetterOrDigit(ch))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }

            return true;
        }

        static bool AtLeastTwoDigits(string password)
        {
            int digits = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }

            if (digits >= 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
        }


    }
}
