using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_pg218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a random number. I am going to log it to a text file.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\addie\Desktop\GitHub\C-sharp_small_projects\Assignment_pg218\logs.txt", text);

            string text2 = File.ReadAllText(@"C:\Users\addie\Desktop\GitHub\C-sharp_small_projects\Assignment_pg218\logs.txt");
            Console.WriteLine("The file reads " + text2);
            Console.ReadLine();

        }
    }

}
