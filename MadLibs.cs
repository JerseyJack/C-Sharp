using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class MadLibs
    {
        public static void CreateMadLib()
        {
            string colour, plural, vege;

            Console.WriteLine("Let's create a Mad Lib!");

            Console.Write("Enter a colour: ");
            colour = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            plural = Console.ReadLine();

            Console.Write("Enter a vegetable: ");
            vege = Console.ReadLine();

            Console.WriteLine("\nRoses are " + colour);
            Console.WriteLine(plural + " are blue");
            Console.WriteLine("I love " + vege);
            Console.ReadLine();

        }
    }
}
