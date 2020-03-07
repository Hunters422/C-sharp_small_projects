using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg202
{
    class Program
    {
        
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>
             {
            new Employee { Id = 1, FirstName = "Robert", LastName = "Gold"},
            new Employee { Id = 2, FirstName = "Joe", LastName = "Dirty"},
            new Employee { Id = 3, FirstName = "Joe", LastName = "Couch" },
            new Employee { Id = 4, FirstName = "Timmy", LastName = "Southpark" },
            new Employee { Id = 5, FirstName = "Jack", LastName = "Skeleton" },
            new Employee { Id = 6, FirstName = "Stud", LastName = "Muffin" },
            new Employee { Id = 7, FirstName = "Anakin", LastName = "Skywalker" },
            new Employee { Id = 8, FirstName = "Ackali", LastName = "Cloudstalker" },
            new Employee { Id = 9, FirstName = "Bob", LastName = "Lame" },
            new Employee { Id = 10, FirstName = "Sue", LastName = "Anne" },
            };

            List<Employee> joeList = new List<Employee>();
            foreach (Employee Joe in empList)
            {
                if (Joe.FirstName == "Joe")
                {
                    joeList.Add(Joe);
                }

            }
            foreach (Employee Joe in joeList)
            {
                Console.WriteLine(Joe.FirstName);
            }
            
            Console.ReadLine();

            List<Employee> lambdaList = empList.Where(item => item.FirstName == "Joe").ToList();
            foreach ( Employee item in lambdaList)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();

            List<Employee> lambdaId = empList.Where(x => x.Id > 5).ToList();
            foreach (Employee x in lambdaId)
            {
                Console.WriteLine(x.Id);
            }
            Console.ReadLine();
        }
    }
}
