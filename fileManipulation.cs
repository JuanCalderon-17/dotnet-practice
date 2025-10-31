using System;

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
    }
}
