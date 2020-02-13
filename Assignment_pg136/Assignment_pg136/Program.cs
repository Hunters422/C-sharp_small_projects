using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        string[] strArray = { "Harry", "Potter", "Ron", "Weasley" };
        Console.WriteLine("Please select an index of the Array: ");
        int selectArray = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(strArray[selectArray]);
        Console.ReadLine();
        List<string> intList = new List<string>();
        intList.Add("Once");
        intList.Add("Upon?");
        intList.Add("a time");
        intList.Add("in Neverland");

        int[] numArray = new int[] { 7, 14, 21, 28, 35 };
        string[] str1;
        str1 = new string[] { "red", "white", "blue", "green" };

        bool infloop = true;
        while (infloop == true)
        {
            Console.WriteLine("Please choose an index number between 0-4");
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("You got: " + numArray[input]);

            }
            catch
            {
                Console.WriteLine("Please selecct a valid index");
            }

            Console.WriteLine("Please choose an index number bewteen 0-3");
            try
            {
                int input2 = int.Parse(Console.ReadLine());
                Console.WriteLine("You got: " + str1[input2]);

            }
            catch
            {
                Console.WriteLine("Please selecct a valid index");
            }


            Console.WriteLine("Please choose an index number bewteen 0-3");
            try
            {
                int input3 = int.Parse(Console.ReadLine());
                Console.WriteLine("You got: " + intList[input3]);

            }
            catch
            {
                Console.WriteLine("Please selecct a valid index");
            }
            infloop = false;
        }

        Console.ReadLine();

    }
}
