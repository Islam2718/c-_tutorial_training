﻿// area calculator.. of traingle.
/*
    Console.readLine();
*/

using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {
        // area = 0.5 * base * height
        // 
        Console.Write("Insert Base: ");
        string? baseValue = Console.ReadLine();
        Console.Write("Insert Height: ");
        string? heightValue = Console.ReadLine();

        double area = 0.5 * Convert.ToDouble(baseValue) * Convert.ToDouble(heightValue);
        Console.Write("The area of traingle is: " + area);
        
    }
}