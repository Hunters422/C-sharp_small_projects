using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg159
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass a = new myClass();

            Console.WriteLine("Please type in a number to add to 10: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result1 = a.addMethod(x);
            Console.WriteLine("The number you selected plus 10 equals: " + result1);
            Console.ReadLine();


            Console.WriteLine("Please type in a decimal to times by 10: ");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            int result2 = a.addMethod(y);
            Console.WriteLine("The number you selected times 10 equals: " + result2);
            Console.ReadLine();

            Console.WriteLine("Please type in a string to convert to an int and divide by 10: ");
            string input = Console.ReadLine();
            int result3 = a.addMethod(input);
            Console.WriteLine("Please spell a number to convert to a integer and divide by 10: " + result3);           
            Console.ReadLine();

        }
    }
}
