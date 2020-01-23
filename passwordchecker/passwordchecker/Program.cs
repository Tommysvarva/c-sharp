using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChars = "!\"#¤%&/()=?";

            Console.WriteLine("Type in a password...");
            string password = Console.ReadLine();
            int score = 0;

            if (password.Length >= minLength) { 
            
                score++;
            }
            if (password.Contains(uppercase))
            {
                score++;
            }
            if (password.Contains(lowercase))
            {
                score++;
            }
            if (password.Contains(digits))
            {
                score++;
            }
            if (password.Contains(specialChars))
            {
                score++;
            }
            Console.WriteLine(score);
            Console.ReadLine();
        }
    }
}