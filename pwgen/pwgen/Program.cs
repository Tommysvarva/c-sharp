using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwgen
{
    class Program
    {
        static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                showHelpText();
                return;
            }
            var length = Convert.ToInt32(args[0]);
            var options = args[1];
            var pattern = options.PadRight(length, 'l');
            var password = string.Empty;

            while (pattern.Length > 0)
            {
                var randomIndex = Random.Next(0, pattern.Length - 1);
                var category = pattern[randomIndex];

                pattern = pattern.Substring(0, randomIndex) + pattern.Substring(randomIndex + 1, pattern.Length -randomIndex -1);
                if (category == 'l') password += GetRandomLowerLetter();
                else if (category == 'L') password += GetRandomLowerLetter();
                else if (category == 'd') password += GetRandomDigit();
                else password += GetRandomDigit();
            }
            Console.WriteLine(password);
        }

        private static char GetRandomSpecialCharacter()
        {
            var allSpecial = "!#¤%&/()=?";
            var index = Random.Next(0, allSpecial.Length - 1);
            return allSpecial[index];
        }
        private static char GetRandomLowerLetter()
        {
            return GetRandomLetter('a', 'z');
        }
        private static char GetRandomUpperLetter()
        {
            return GetRandomLetter('A', 'Z');
        }
        private static char GetRandomLetter(char min,char max)
        {
            return (char)Random.Next(min, max + 1);

        }
        private static int GetRandomDigit()
        {
            return Random.Next(0, 10);
        }
        private static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;
            var letters = args[0];
            var options = args[1];

            foreach (var character in options)
            {
                if (character != 'l'
                    & character != 'L'
                    & character != 'd'
                    & character != 's')
                {
                    return false;
                }
                        
            }
            foreach (var character in letters)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }
            return true;
        }

        private static void showHelpText()
        {
            Console.WriteLine("PasswordGenerator <length> <options>");
            Console.WriteLine("  Options:");
            Console.WriteLine("  - l = lower case letter");
            Console.WriteLine("  - L = upper case letter");
            Console.WriteLine("  - d = digit");
            Console.WriteLine("  - s = special character (!\"#¤%&/(){}[]");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special characters");
            Console.WriteLine("         Min. 2 digits");
        }
    }
}
