using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_192
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is the current day of the week?: ");
                string input = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("Dope! Thanks.");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("That would be wrong. Do me a favor, just real quick, and enter a valid day of the week. \nJust thinking of the song, it will come to you: ");
                string input = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("Dope! Thanks.");
                Console.ReadLine();
            }
        }


    }
}