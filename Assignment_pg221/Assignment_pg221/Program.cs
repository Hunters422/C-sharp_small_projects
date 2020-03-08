using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg221
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current Date and Time is : " + currentTime);
            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It will be " + currentTime.AddHours(input) + " in " + input + " hours ");
            Console.WriteLine("Also, time is just in illuuuuuusion. Oof..spooky 0.o");
            Console.ReadLine();
        }
    }
}
