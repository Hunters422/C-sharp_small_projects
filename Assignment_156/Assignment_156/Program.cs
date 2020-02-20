using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_156
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass a = new myClass();
            Console.WriteLine("Please select a random number to perform 3 basic math operations on: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you selected plus 10 equals: " + a.addTwo(x));
            Console.WriteLine("The number you selected times 10 equals: " + a.timesTwo(x));
            Console.WriteLine("The number you selected divided by 10 equals: " + a.divideTwo(x));
            Console.ReadLine();



        }
    }
}
