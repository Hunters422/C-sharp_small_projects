﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg235
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowDate = DateTime.Now;
            Console.WriteLine("What age are you?");
            while (true)
            {
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age > 0)
                    {
                        Console.WriteLine("You are " + nowDate.AddYears(-age).Year + " years old.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid age.");
                        Console.ReadLine();
                    }

                }

                catch (FormatException)
                {
                    Console.WriteLine("Hiya! An error occurred, and instead of telling you exactly what the issue is and how \nto fix it, I'm just going to give you this generic \nmessage for the lolz. Have a nice day!");
                    Console.ReadLine();
                }
                break;
            }
        }
    }
}