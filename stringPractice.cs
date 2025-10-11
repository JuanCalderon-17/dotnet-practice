using System;
using System.Runtime.CompilerServices;
using System.Linq;

namespace dotnetPractice
{
    class stringPractice
    {
        public string  _sentence = String.Empty;
        public void maxLengthMaker(string sentence)
        {
            _sentence = sentence;
            const int maxLength = 20;

            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(" ");
                string allWords = "";

                foreach (var word in words)
                {
                    allWords += word + " ";

                }

                Console.WriteLine("The words are = " + allWords);
                Console.WriteLine($"The words count is = {words.Length}");

            }
            
        }
        
    }

}