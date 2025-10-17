using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Globalization;

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



        //1. Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
        //  For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".


        public void consecutive()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            string? input = Console.ReadLine();
            var numberList = new List<int>();
            string[]? numbers = input?.Split("-");


            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int num))
                {
                    numberList.Add(num);
                }
                else
                {
                    Console.WriteLine("Not a valid number");
                }
            }

            var IsConsecutive = true;
            for (int i = 1; i < numberList.Count - 1; i++)
            {
                if (numberList[i] >= numberList[i + 1])
                {
                    Console.WriteLine("Not Consecutiv");
                    IsConsecutive = false;
                    break;
                }
            }

            if (IsConsecutive)
            {
                Console.WriteLine("Consecutive");
            }

        }
    }
}