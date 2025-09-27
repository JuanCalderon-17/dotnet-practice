using System.ComponentModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace dotnetpractice;


class Arraylist
{
    /*
    static void Arraypractice()
    {
        var numbers = new int[] { 3, 7, 11, 21, 5, 12 };

        //length
        Console.WriteLine("Length" + numbers.Length);
    }

    static void Listpractice()
    {
        var numbers = new List<int> { 1, 2, 3, 4 };
        numbers.Add(1);
        numbers.AddRange(new int[3] { 5, 6, 7 });

        foreach (var number in numbers)
            Console.WriteLine(number);


        Console.WriteLine();
        Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
        Console.WriteLine("Last Index of 1: " + numbers.IndexOf(1));

        Console.WriteLine("Count: " + numbers.Count);

        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
                numbers.Remove(numbers[i]);
        }

        foreach (var number in numbers)
            Console.WriteLine(number);

        numbers.Clear();
        Console.WriteLine("Count: " + numbers.Count);

        
    public void facebookLikeCounter()
    {
        Console.WriteLine("Please enter different names: ");
        var input = Console.ReadLine();

        List<string> nombres = new List<string>();

        while (input != "")
        {

            nombres.Add(input);

        }
    } 

                Console.Write("Please enter different names: ");
            String? input = Console.ReadLine();

            List<string> nombres = new List<string>();

            if (!string.IsNullOrEmpty(input))
            {
                var part = input.Split(',');

                foreach (var nombreIndividual in part)
                {
                    nombres.Add(nombreIndividual.Trim().ToUpper());
                }
            }
            else
            {
                Console.WriteLine("");
            }

            int cantidad = nombres.Count;
            switch (cantidad)
            {
                case 1:
                    Console.WriteLine($"{nombres[0]} liked your post.");
                    break;
                case 2:
                    Console.WriteLine($"{nombres[0]} and {nombres[1]} liked your post.");
                    break;
                default:
                    Console.WriteLine($"{nombres[0]}, {nombres[1]} and {nombres.Count - 2} others like your post.");
                    break;
            }
        

    //2- Write a program and ask the user to enter their name.
    //  Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

    public void reverseName()
    {
        Console.Write("Please enter your name;");
        String? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid name.");
            return;
        }

        Char[] charArray = input.ToArray();
        Array.Reverse(charArray);

        Console.WriteLine(new String(charArray));     
          
    }
    */
}