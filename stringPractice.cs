using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace dotnetPractice
{
    class stringPractice
    {
        public string _sentence = String.Empty;
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


        //Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input,
        //exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

        public void duplicates()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            string? input = Console.ReadLine();
            var numberList = new List<int>();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var parts = input.Split("-");
                foreach (var part in parts)
                {
                    if (int.TryParse(part.Trim(), out int number))
                    {
                        numberList.Add(number);
                    }
                }

                bool hasDuplicate = false;
                HashSet<int> uniqueIdentifier = new HashSet<int>();
                foreach (int num in numberList)
                {
                    if (uniqueIdentifier.Contains(num))
                    {
                        hasDuplicate = true;
                    }
                    else
                    {
                        uniqueIdentifier.Add(num);
                    }
                }

                if (hasDuplicate)
                {
                    Console.WriteLine("Duplicates");
                }
                else
                {
                    Console.WriteLine("No Duplicates");
                }

            }
            else
            {
                Console.WriteLine("You should write something!");
            }
        }
        

        //Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
        //  So, if the user enters "inadequate", the program should display 6 on the console.

        public void vocalCount()
        {
            Console.WriteLine("Enter an English word: ");
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                var hasVowels = Regex.Matches(input, "[aeiou]");

                int numberOfTimes = hasVowels.Count();
                Console.WriteLine($"The amount of vowels in the code is: {numberOfTimes}");

                
            }
        }
    }
}