using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace dotnetpractice
{
    class fileManipulation
    {
        //Write a program that reads a text file and displays the number of words.
        public static void numberWords(string file)
        {
            var lengthText = File.ReadAllText(file);
            var len = lengthText.Length;

            Console.WriteLine("Words: " + len);
        }


        //Write a program that reads a text file and displays the longest word in the file.
        public static void longestWord(string file)
        {
            var i = 0;
            string longest = "";
            var text = File.ReadAllText(file);

            text = Regex.Replace(text, @"[^\w\s]", "");
            var wordsCollection = Regex.Split(text, @"\s+");

            foreach (var word in wordsCollection)
            {
                var trimmedWord = word.Trim();
                if (trimmedWord.Length == 0) continue;
                
                if (trimmedWord.Length > i)
                {
                    longest = trimmedWord;
                    i = trimmedWord.Length;
                }
                else
                    continue;

            }

            Console.WriteLine($"The longest word is: {longest}");
       
        }     
    }
}
