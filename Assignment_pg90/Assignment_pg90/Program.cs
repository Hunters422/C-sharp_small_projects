using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg90
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int hourly1;
            int hoursWorked1;
            int hourly2;
            int hoursWorked2;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();


            Console.WriteLine("Person 1: {0}Please Enter Hourly Wage: ", Environment.NewLine);
            hourly1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the amount of hours worked this week:");
            hoursWorked1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2: {0}Please Enter Hourly Wage:", Environment.NewLine);
            hourly2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the amount of hours worked this week:");
            hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int wsalary1 = hourly1 + hoursWorked1;
            int annualSalary1 = wsalary1 * 52;
            Console.WriteLine("Person 1 Annual Salary: " + annualSalary1);
            Console.ReadLine();

            int wsalary2 = hourly2 + hoursWorked2;
            int annualSalary2 = wsalary2 * 52;
            Console.WriteLine("Person 2 Annual Salary: " + annualSalary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool trueOrfalse = annualSalary1 > annualSalary2;
            Console.WriteLine(trueOrfalse);
            Console.ReadLine();

            
        }
    }
}
