using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg131
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "At the moment, I am concatenating 3 strings" +
            //            "for my assignment, which" +
            //            " is on page 131.";

            //Console.WriteLine(text);
            //Console.ReadLine();

            //string upperExample = "this is me screaming using all caps!";
            //string upperExample1 = upperExample.ToUpper();
            //Console.WriteLine(upperExample1);
            //Console.ReadLine();

            StringBuilder builder = new StringBuilder("Hello Everyone!");
            builder.Append("This is a my example of using string builder.");
            builder.AppendLine();
            builder.Append("So far, I have really enjoyed C#.").AppendLine();
            builder.AppendLine("I find it very easy to research all of the issues that I have run into.");
            builder.AppendLine("In addition, my instructor has helped clarify some minor errors I have encountered.");
            builder.AppendLine("I just want to thank you for taking the time to read this paragraph.");
            Console.WriteLine(builder);
            Console.ReadLine();

        }
    }
}
