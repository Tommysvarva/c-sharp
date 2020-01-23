
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Program
    {
        static readonly Random Random = new Random();
        
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }

            // Variables
            var length = Convert.ToInt32(args[0]); // lengden på passordet. 
            var options = args[1]; // argument 1 (valgene (stor,liten,spesialtegn etc.))
            var pattern = options.PadRight(length, 'l'); // ???????
            var password = string.Empty; // Lager en tom string

            while (pattern.Length > 0)
            {
                var randomIndex = Random.Next(0, pattern.Length - 1);
                Console.WriteLine($"random index = {randomIndex}");
                var category = pattern[randomIndex];
                Console.WriteLine($"Category = {category}");


                pattern = pattern.Substring(0, randomIndex)
                        + pattern.Substring(randomIndex + 1, pattern.Length - randomIndex - 1);

                if (category == 'l') password += GetRandomLowerCaseLetter();
                else if (category == 'L') password += GetRandomUpperCaseLetter();
                else if (category == 'd') password += GetRandomDigit();
                else password += GetRandomSpecialCharacter();
            }
            Console.WriteLine(password);
        }

        // Returnerer en char basert på en random posisjon i et array. 
        private static char GetRandomSpecialCharacter()
        {
            var allSpecialCharacters = "!\"#¤%&/(){}[]";
            var index = Random.Next(0, allSpecialCharacters.Length - 1);
            return allSpecialCharacters[index];
        }

        // Tar å genererer et random tall mellom 0 og 10 og returnerer en int. 
        private static int GetRandomDigit()
        {
            return Random.Next(0, 10);
        }

        // Returnerer med store bokstaver
        private static char GetRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        // Returnerer med små bokstaver
        private static char GetRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z');
        }

        // Returnerer en tilfeldig bokstav basert på 2 parameter
        private static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max + 1);
        }


        // Metode for å sjekke om argumentene vi har sendt med er valid. Sender med resultat iform av bool.
        private static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;

            var lengthStr = args[0];
            var options = args[1];


            // Sjekker om options inneholder en char med noen av følgende verdier.
            foreach (var character in options)
            {
                if (character != 'l'
                    && character != 'L'
                    && character != 'd'
                    && character != 's')
                {
                    return false;
                }
            }

            // sjekker om en verdi i lengthStr ikke er tall.
            foreach (var character in lengthStr)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }
            return true;

        }


        // En motode som viser følgende teks hvis ikke argumentene som er sendt oppfyller krav. 
        private static void ShowHelpText()
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
