using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg159
{
    public class myClass
    {
        public int addMethod(int x)
        {
            int result = x + 10;
            return result;

        }
        public int addMethod(decimal y)
        {
            //Console.WriteLine("Please type in a decimal number: ");
            //decimal y = Convert.ToDecimal(Console.ReadLine());

            int result2 = Convert.ToInt32(y * 10);
            return result2;

        }
        public int addMethod(string input)
        {
            //Console.WriteLine("Please spell a number to convert to a integer and divide by 10: ");

            int result3 = Convert.ToInt32(input) / 10;
            return result3;
        }
    }
}

