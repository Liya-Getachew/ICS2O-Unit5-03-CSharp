// Created by: liya getachew
// Created on: Nov 23 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function tells the user what movies they can watch 
        int age;

        Console.WriteLine("Insert your age here and I'll tell you what movies you can watch!");
        Console.WriteLine();

        Console.WriteLine("your age goes here: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (age >= 17)
        {
            Console.WriteLine("You're old enough to watch any R movie by yourself.");
        }
        else if (age >= 13)
        {
            Console.WriteLine("For someone your age, PG-13 movies would be the best.");
        }
        else if (age >= 5)
        {
            Console.WriteLine("You can watch only PG and G movies for now.");
        }
        else
        {
            Console.WriteLine("Go take a nap, kid.");
        }

        Console.WriteLine("\nDone.");
    }
}