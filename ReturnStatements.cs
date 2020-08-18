using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class ReturnStatements
    {
        public static void ReturnMain()
        {
            Console.Write("Aight bruv, give us a number, I'll square it for you...\n");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Cube(number);

            Console.WriteLine("'Ere ya go... " + result);

            Console.ReadLine();

        }

        static int Cube(int number) //The retuen type here is int. It returns an integer to the method that called this one. You can do the same for other data types, and even arrays
        {
            int cube = number * number * number;
            return cube;
        }
    }
}
