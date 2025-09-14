using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            -------1 EXERCISE

            
            1- Write a program to count how many numbers
            between 1 and 100 are divisible by 3 with no remainder.
            Display the count on the console. 
            int conteo = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    conteo++;
                }

            }
            Console.WriteLine(conteo);
            

            -------2 EXERCISE

            int number = 0;
            var validation = "";
            var sum = 0;

            while (validation != "ok")
            {
                Console.Write("Write \"ok\" to exit or a number to add: ");
                validation = Console.ReadLine();
                if (validation == "ok")
                {
                    break;
                }

                bool booleano = int.TryParse(validation, out number);

                if (booleano)
                {
                    sum += number;
                }
            }

            Console.Write("The sum is " + sum);

            


            //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
            // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.



            -------3 EXERCISE 
            int number = 0;
            Console.Write("Enter a number: ");
            bool userInput = int.TryParse(Console.ReadLine(), out number);
            var result = 1;

            if (userInput)
            {
                for (int i = 1; i <= number; i++)
                {
                    result = result * i;
                }
            }
            else
            {
                Console.WriteLine("Write an acual integer");
            }
            Console.WriteLine($"{number}! = {result}");
        
        

            //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            //  If the user guesses the number, display “You won"; otherwise, display “You lost". 
            // (To make sure the program is behaving correctly, you can display the secret number on the console first.)


         -------4 EXERCISE
            Random random = new Random();
            var randomNumber = random.Next(1, 10);
            int number = 0;


            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess a number from 1 - 10, you got 4 chances: ");
                string? input = Console.ReadLine();
                
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number == randomNumber)
                    {
                        Console.WriteLine($"Yo guess correctly, your {number} is equivalent to the random number {randomNumber}!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect. Try again! The number was {randomNumber}");
                    }
                }
            }
            
         -------4 EXERCISE

            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Please enter a series of numbers separated by comma");
            var input = Console.ReadLine();

            List<int> numbers = new List<int>();


            foreach (var part in input.Split(','))
            {
                var trimmed = part.Trim();
                if (int.TryParse(trimmed, out int num))
                {
                    numbers.Add(num);
                }
            }

            var maxNumber = numbers.Max();
            Console.Write($"The Maximun number is {maxNumber}");

            */


            
    
        }
    }
}