using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using System.IO.Pipes;
using System.Collections;
using Arraylist = dotnetpractice.Arraylist;
using System.Numerics;

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


            Arraylist person = new Arraylist();
            person.reverseName();
            

            Arraylist identityNumbers = new Arraylist();
            identityNumbers.uniqueNumbers();

            Arraylist names = new Arraylist();


            Arraylist JuegaSale = new Arraylist();
            JuegaSale.quitOrContinue();

            Arraylist matriz = new Arraylist();
            matriz.ThreeSmallestNumbers();


            //dateTime exercises and examples 

            fechaDia fecha = new fechaDia();
            fecha.MostrarFecha(args);

            var timespan1 = new TimeSpan(1, 2, 3);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            Console.WriteLine(start);
            Console.WriteLine(end);
            Console.WriteLine($"Duration: {end - start}");

            //Properties
            Console.WriteLine("Minutes: " + timespan1.Minutes);
            Console.WriteLine("Total Minutes: " + timespan1.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timespan1.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtraction example: " + timespan1.Subtract(TimeSpan.FromHours(1)));

            var nombreComp = "Juan Calderon ";

            Console.WriteLine($"Trim: '{nombreComp.Trim()}'");
            Console.WriteLine($"ToUpper: '{nombreComp.ToUpper()}'");
            Console.WriteLine($"ToLower: {nombreComp.ToLower()}");

            var index = nombreComp.IndexOf(" ");
            var firstName = nombreComp.Substring(0, index);
            var lastName = nombreComp.Substring(index + 1);
            Console.WriteLine($"First name:" + firstName);
            Console.WriteLine($"Last name: " + lastName);

            var names = nombreComp.Split(' ');
            Console.WriteLine($"First Name: " + names[0]);
            Console.WriteLine($"Last Name: " + names[1]);

            Console.WriteLine($"Replace :" + nombreComp.Replace("Juan", "Juanito"));

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); //currency*/



            stringPractice practicando = new stringPractice();

            practicando.maxLengthMaker("this is a very long really and really really long paragraph");


        }
        
    }
}