using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg72
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "The Tech Academy" +
            Environment.NewLine +
            "Student Daily Report:";
            Console.Write(x);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What Page number?");
            string currentPage = Console.ReadLine();
            int pgNumber = Convert.ToInt32(currentPage);

            Console.WriteLine("Do you need any Help? Please answer 'True' or 'False'");
            bool yesHelp = true;
            bool noHelp = false;
            if (yesHelp)
            {
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }

            Console.WriteLine("Were there any positive experiences that you would like to share? Please give specifics.");
            string feedbackPos = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to provide? PLease be specific.");
            string feedbackOther = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
