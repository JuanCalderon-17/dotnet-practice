using System.ComponentModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace dotnetpractice;


class Arraylist
{
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
    }
}