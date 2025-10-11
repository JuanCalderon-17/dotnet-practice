using System;
using System.Runtime.CompilerServices;

namespace dotnetPractice
{
    class stringPractice
    {

        static void maxLengthMaker()
        {
            
            string sentence = "this is going to be a really really really really long string";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(" ");
                var totalCaracthers = words.Count();
            }
            
        }
        
    }

}