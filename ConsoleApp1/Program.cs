using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Mobile no. : ");
        var data = Console.ReadLine();
        string pattern = "^[+][][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";

        Regex regex = new Regex(pattern);

        if (regex.IsMatch(data))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It is Valid number");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid");
            Console.ResetColor();
        }
        
    }
}