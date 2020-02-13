using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        string[] strArray = { "Harry", "Potter", "Ron", "Weasley" };
        Console.WriteLine("Please select an index of the Array: ");
        string selectArray = Console.ReadLine();
        Console.WriteLine(selectArray[0]);
        Console.ReadLine();
        }
    }