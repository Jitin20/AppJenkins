﻿using System;
using MyCalc;
namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Calc calc = new Calc();
            Console.WriteLine($"Sum = {calc.Add(70,80)}");
            Console.WriteLine($"Multiply = {calc.Multiply(6, 5)}");
            Console.WriteLine($"Subtraction = {calc.Subt(20 , 10)}");
            Console.ReadLine();
        }
    }
}
