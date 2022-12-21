using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Last Name: ");
        var data = Console.ReadLine();
        string pattern = "^[A-Z]{1}[a-z]{2,}$";

        Regex regex = new Regex(pattern);

        if (regex.IsMatch(data))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It is Valid name");
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