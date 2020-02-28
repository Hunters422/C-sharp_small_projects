using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg184
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Jack";
            employee.LastName = "Skeleton";
            employee.Id = 24;

            Employee employee2 = new Employee();
            employee2.FirstName = "Luke";
            employee2.LastName = "Skywalker";
            employee.Id = 34;

            Console.ReadLine();
        }
    }
}
