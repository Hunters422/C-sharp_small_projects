using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg231
{
    class Program
    {
        private string greeting;

        static void Main(string[] args)
        {
            const string greeting = "Everybody was,";
            string var = "KUNGFOO FIGHTIN";
            Console.WriteLine(greeting + var);
            Console.ReadLine();
        }
        public Program(string greeting, string var) : this(greeting)
        {

            var = greeting;
        }

        public Program(string greeting)
        {
            this.greeting = greeting;
        }
    }
}
