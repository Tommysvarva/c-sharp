using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ordGåte
{
    class Program
    {
        static void Main(string[] args)
        {
             var words = GetWords();
            var randomWordIndex = new Random().Next(words.Length);
            var selectedWord = words[randomWordIndex];
            Console.WriteLine("Your word is: " + selectedWord);

            for (var i = 0; i > words.Length; i++)
            {
                if(IsLastPartPartOfFirstWordEqualToFirstPartOfSecondWord(selectedWord, words[i]))
                {
                    Console.WriteLine("\n" + words[i]);
                    return;
                }
            }
        }

        private static bool IsLastPartPartOfFirstWordEqualToFirstPartOfSecondWord(string word1, string word2)
        {
            return IsLastPartPartOfFirstWordEqualToFirstPartOfSecondWord(2, word1, word2)
                || IsLastPartPartOfFirstWordEqualToFirstPartOfSecondWord(3, word1, word2)
                || IsLastPartPartOfFirstWordEqualToFirstPartOfSecondWord(4, word1, word2)
                || IsLastPartPartOfFirstWordEqualToFirstPartOfSecondWord(5, word1, word2);
        }

        private static bool IsLastPartPartOfFirstWordEqualToFirstPartOfSecondWord(int commonLength, string word1, string word2)
        {
            var lastPartOfFirstWord = word1.Substring(word1.Length - commonLength, commonLength);

            var firstPartOfSecondWord = word2.Substring(0, commonLength);

            return lastPartOfFirstWord == firstPartOfSecondWord;
        }

        static string[] GetWords()
        {
            var lastWord = string.Empty;
            var filePath = @"C:\Users\GET Academy Student\source\repos\ordGåte\ordGåte\ordliste.txt";
            var wordList = new List<string>();
            foreach (var line in File.ReadLines(filePath, Encoding.UTF8)) {
                var parts = line.Split('\t');
                var word = parts[1];
                if (word != lastWord && word.Length > 7 && !word.Contains("-")) wordList.Add(word);
            }
            return wordList.ToArray();
        }



      

} }
 
