using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg164
{
    class Output
    {
        public void outputMethod()
        {
            int i;
            Addition(out i);
            Console.WriteLine("The addition output is: {0}", i);
        }


        public static void Addition(out int i)
        {
            i = 69;
            i += i;
        }


    }
}
