using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg147
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listElements = new List<int>();
            listElements.Add(700);
            listElements.Add(85);
            listElements.Add(45);
            listElements.Add(28);
            listElements.Add(61);
            listElements.Add(38);

            bool Keeplooping = true;
            while (Keeplooping == true)
            {
                Console.WriteLine("Please pick a number to divide each list interger by: ");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    foreach (int i in listElements)
                    {
                        string result = Convert.ToString((i / userInput));
                        Console.WriteLine(i + " divided by " + userInput + " equals " + result);
                    }
                    Console.ReadLine();

                }
                catch
                {
                    Console.WriteLine("Please selecct a valid integer");
                }

            }
        }
    }
}
