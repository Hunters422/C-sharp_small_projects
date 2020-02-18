using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg146
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strArray = { "Harry ", "Hermoine ", "Ron ", "Hagrid ", "Dumbledore " };
            //Console.WriteLine("Please enter some text: ");
            //string userText = Console.ReadLine();
            //foreach (string s in strArray)
            //{
            //    Console.WriteLine(s + userText);
            //}
            //Console.ReadLine();




            //while (true)
            //{
            //    Console.WriteLine(" Creating Infinite Loop");
            //}



            //int i = 0;
            //while (i == 0)
            //{
            //    Console.WriteLine("Breaking Infinite Loop");
            //    i++;

            //}
            //Console.ReadLine();



            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Using '<' for comaprison.");
            //    i++;
            //}
            //Console.ReadLine();


            //int i = 0;
            //while (i <= 20)
            //{
            //    Console.WriteLine("Using '<=' for comparison");
            //    i++;
            //}
            //Console.ReadLine();


            //List<string> listItems = new List<string>();
            //listItems.Add("Harry Potter");
            //listItems.Add("Anakin Skywalker");
            //listItems.Add("Darth Vader");
            //listItems.Add("Voldemort");
            //listItems.Add("Rick and Morty");
            //listItems.Add("Courage the Cowardly Dog");
            //listItems.Add("Batman");
            //foreach (string listItem in listItems)
            //{
            //    Console.WriteLine(listItem);
            //}
            //Console.ReadLine();
            //Console.WriteLine("Who has the most swag? Copy exactly and I'll return its index for you.");
            //string userInput = Console.ReadLine();
            //for (int i = 0; i < listItems.Count; i++)
            //{
            //    if (listItems[i] == userInput)
            //    {
            //        Console.WriteLine("The index of your input: " + i);
            //        break;
            //    }

            //    else if (listItems[i] != userInput)
            //        Console.WriteLine("Please COPY EXACTLY FROM THE LIST: ");
            //}
            //Console.ReadLine();



            //List<string> listItems = new List<string>();
            //listItems.Add("Hello");
            //listItems.Add("Hello");
            //listItems.Add("Good Bye");
            //listItems.Add("Thank you");
            //foreach (string listItem in listItems)
            //{
            //    Console.WriteLine(listItem);
            //}
            //Console.ReadLine();
            //Console.WriteLine("Select text to search for in the List:");
            //string userInput = Console.ReadLine();
            //for (int i = 0; i < listItems.Count; i++)
            //{
            //    if (listItems[i] == userInput)

            //        Console.WriteLine("The index of your input: " + i);    

            //    else if (listItems[i] != userInput)
            //        Console.WriteLine("Please COPY EXACTLY FROM THE LIST: ");
            //}
            //Console.ReadLine();








            
            //part11
           List<string> listItems = new List<string>();
           listItems.Add("Hello");
           listItems.Add("Hello");
            listItems.Add("Good Bye");
            listItems.Add("Thank you");
            foreach (string listItem in listItems)
            {
                Console.WriteLine(listItem); 
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'Hello' appears more than once in this list.");
            Console.ReadLine();
          


        }
    }
}
