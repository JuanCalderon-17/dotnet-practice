using System;
using System.Text;
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

        public void builderPractice()
        {
            var builder = new StringBuilder();

            // both do the same, but im showing how to make the code look shorter and prettier
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder.Replace('-', '+');
            builder.Remove(0, 10);
            Console.WriteLine(builder);


            Console.WriteLine("First car: " + builder[0]);
        }

        

        
    }

}