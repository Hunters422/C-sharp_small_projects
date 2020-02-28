using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg197
{
    class Program
        {
            static void Main(string[] args)
            {
                Number number = new Number();
                number.Amount = 50;
                Console.WriteLine(number.Amount);
                Console.ReadLine();

            }
            struct Number
            {
                public decimal Amount { get; set; }
            }
        }
}