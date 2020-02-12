using System;

namespace Assignment_pg123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            else if (packWeight < 50)
            {
                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length:");
                int packLength = Convert.ToInt32(Console.ReadLine());

                int packDim = (packLength + 2 * packWidth + 2 * packHeight);

                if (packDim > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                else if (packDim < 50)
                {
                    int packPrice = (packDim * packWeight / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + packPrice);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
            }


        }
    }
}