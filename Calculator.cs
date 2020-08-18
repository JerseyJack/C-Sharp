using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class Calculator
    {
        public static void Calc()
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.Write("Enter a number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another to add to it: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);
            Console.ReadLine();
        }
    }
}
