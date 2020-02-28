using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg179
{
    public class Employee : Assignment_pg179.IQuittable

    {
        public void Quit()
        {
            Console.Write("I quit");
        }
    }
}