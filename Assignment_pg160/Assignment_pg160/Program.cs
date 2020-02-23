using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg160
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass a = new myClass();

            //Console.WriteLine("Please input two numbers. We are going to take those numbers, add them together, and then add 15. First Number: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second Number: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int result = a.addMethod(x,y);
            //Console.WriteLine(x + y + " plus 15 equals " + result);
            //Console.ReadLine();

            Console.WriteLine("Please type enter in a number. You can type in a second number if you wish but you may leave it blank.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And second number if you choose: ");
            if (string.IsNullOrEmpty(Console.ReadLine()))
            {
                int y = Convert.ToInt32(0);
                int result = a.addMethod(x, y);
                Console.WriteLine("Your number(s) plus 15 equals " + result);
                Console.ReadLine();


            } 
            else
            {
                int y = Convert.ToInt32(Console.ReadLine());
                int result = a.addMethod(x, y);
                Console.WriteLine("Your number(s) plus 15 equals " + result);
                Console.ReadLine();

            }




        }
    }
}
