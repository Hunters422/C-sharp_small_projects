﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg161
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass a = new myClass();

            int x = 15;
            int y = 25;
            a.addMethod(x: x, y: y);
            Console.ReadLine();

        }
    }
}