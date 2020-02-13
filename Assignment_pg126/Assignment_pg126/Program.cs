using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg126
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool isTrue = true;
            //while (isTrue)
            //{
            //    Console.WriteLine(isTrue);
            //    isTrue = false;
            //    Console.WriteLine(isTrue);
            //}
            //Console.ReadLine();

            Console.WriteLine("Pick a number between 1-10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberGuess = number == 6;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("1? Wrooooong. Try Again.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("2? Wrooooong. Try Again.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("3? Wrooooong. Try Again.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("4? Wrooooong. Try Again.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("7! CORRECT!! FINALLY!!...if you want to guess again be my guest...");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Ugh, keep trying!");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!numberGuess);
            Console.ReadLine();
        }
    }
}
