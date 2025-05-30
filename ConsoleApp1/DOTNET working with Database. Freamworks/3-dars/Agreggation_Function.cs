﻿using NCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars;

internal class Agreggation_Function
{
    public static void Start()
    {
        //Sum1();
        //Max1();
        //Min1();
        //Average1();
        //Count1();
        Aggregate();
        //Aggregate2();
    }
    public static void Sum1()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160 };
        //Using Method Syntax
        var ResultMS = numbers.Sum();
        Console.WriteLine("Yig'indi: " + ResultMS);


        //Using Query Syntax
        var ResultQS = (from num in numbers
                                select num).Sum();
        Console.WriteLine($"Yig'indi: {ResultQS}");
    }
    public static void Max1()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 333, 90, 100, 110, 120, 130, 140, 150, 160 };

        
        //Using Query Syntax
        var ResultQS = (from num in numbers
                        select num).Max();
        Console.WriteLine("Max number: " + ResultQS);

        //Using Method Syntax
        var ResultMS = numbers.Max();
        Console.WriteLine($"Max number: {ResultMS}");
    }
    public static void Min1()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160 };
        //Using Query Syntax
        var ResultQS = (from num in numbers
                        select num).Min();
        Console.WriteLine("Min element: " + ResultQS);
        //Using Method Syntax
        var ResultMS = numbers.Min();
        Console.WriteLine("Min numbers: " + ResultMS );
        Console.ReadKey();
    }
    public static void Average1()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160 };
        //Using Query Syntax
        var ResultQS = (from num in numbers
                        select num).Average();
        Console.WriteLine("O'rtacha qiymat: " + ResultQS );

        //Using Method Syntax
        var ResiultMS = numbers.Average();
        Console.WriteLine($"O'rtacha qiymat: {ResiultMS}");
    }
    public static void Count1()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160 };
        //Query Syntax
        var ResultQS = (from num in numbers
                        select num).Count();
        Console.WriteLine($"Query Count: " + ResultQS);

        //Method Syntax
        var ResiultMS = numbers.Count();
        Console.WriteLine("Method Count: " + ResiultMS);
    }
    public static void Aggregate()
    {
        List<int> numbers = new List<int>() { 1, 5, 8, 18, 20 };
       
        
        //Using Method syntax
        int multiply = numbers.Aggregate(func:  (a, b) => a + b);
        Console.WriteLine("Summa: " + multiply);

        int koo = numbers.Aggregate((a, b) => a * b);
        Console.WriteLine("Ko'paytma: " + koo);
        
        
        
        
        
        //Using Query Syntax
        var ResultQS_multiply = (from num in numbers
                        select num).Aggregate(func: (a, b) =>  (a + b));

        var ResultQS_koo = (from num in numbers
                            select num).Aggregate(func: (a, b) => a * b);
        Console.WriteLine("Query Syntax");
        Console.WriteLine("Summa: " + ResultQS_multiply);
        Console.WriteLine("Ko'paytma: " + ResultQS_koo);
        Console.Read();
    }
    public static void Aggregate2()
    {
        List<int> numbers = new List<int>() { 1, 5, 8, 18, 20 };
        //Method Syntax
        var ResultMS = numbers.Aggregate(func: Add);
        Console.WriteLine("Method Syntax: " + ResultMS);
        //Query Syntax
        var ResultQS = (from num in numbers
                        select num).Aggregate(func: Add);
        Console.WriteLine("Query Syntax: " + ResultQS);
        Console.Read();
    }
    public static int Add(int a, int b) { return a - b; }
}
