using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg164
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass a = new myClass();
            Console.WriteLine("Please select a number to divide by 2: ");
            int x = Convert.ToInt32(Console.ReadLine());
            a.divideMethod(x);
            Console.ReadLine();

            Output z = new Output();
            z.outputMethod();
            Output.Addition(out int i);


            int total1 = Overload.addMethod(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + total1);

            int total2 = Overload.addMethod(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + total2);

            Console.ReadLine();
        }
    }
}
