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
            //    string newString = s + userText;
            //    Console.WriteLine(newString);
            //}
            //Console.ReadLine();


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
            listItems.Add("hi");
            listItems.Add("just");
            listItems.Add("hi");
            listItems.Add("hello");
            listItems.Add("hello");
            listItems.Add("whats up");
            listItems.Add("no thank you");
            listItems.Add("Goodbye");
            Dictionary<string, int> newDict = new Dictionary<string, int>();
            List<string> duplicates = new List<string>();

            foreach (string y in listItems)
            {
                Console.WriteLine(y);
                if (newDict.ContainsKey(y))
                {
                    Console.WriteLine("This is a duplicate: " + y);

                }
                else
                {
                    newDict.Add(y, 1);
                }
            }

            Console.ReadLine();



        }
    }
}
