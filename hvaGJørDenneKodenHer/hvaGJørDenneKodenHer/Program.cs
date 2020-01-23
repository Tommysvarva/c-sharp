using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hvaGJørDenneKodenHer
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            int totalCharactersAdded = 0;
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToUpper();
                foreach (var character in text ?? string.Empty)
                {
                    counts[character]++;
                    totalCharactersAdded++;

     

                   
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        int percent = CalculatePersentage(totalCharactersAdded, counts[character]);
                        string output = character + " - ";
                        string output1 = counts[i] + "in percent: " + percent;
                        Console.CursorLeft = Console.BufferWidth - output1.Length - 1;
                        Console.WriteLine(output + output1);

                    }
                }

            }
        }
        static int CalculatePersentage(int amoutOfCharacters, int counts)
        {
            return counts * 100 / amoutOfCharacters;
        }
    }
}
