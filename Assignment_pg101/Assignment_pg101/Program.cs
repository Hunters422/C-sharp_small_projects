using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int currentAge = Convert.ToInt32(age);
            Console.WriteLine("Your age is: " + age);
            Console.ReadLine();


            bool DUIanswer;
            Console.WriteLine("Have you ever had a DUI(True=Yes/False=No)?");
            DUIanswer = bool.Parse(Console.ReadLine());
            Console.WriteLine("You selected: " + DUIanswer);


            Console.WriteLine("How Many Tickets Do You Have?");
            string tickets = Console.ReadLine();
            int numTickets = Convert.ToInt32(tickets);
            Console.WriteLine(numTickets);
            Console.WriteLine("You said you have " + numTickets + " ticket(s).");

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            if (numTickets < 3 && DUIanswer ==true && currentAge > 15)
            {
                Console.WriteLine("Congrats! We can insure you");
                Console.ReadLine();
                
            }
           else
            {
                Console.WriteLine("Sorry, we cannot insure you.");
                Console.ReadLine();
            }

        }
    }
}
