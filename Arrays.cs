using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class Arrays
    {
        public static void ArrayMethod()
        {
            int[] luckyNumbers = {1, 4, 5, 7, 13, 15, 16};

            luckyNumbers[3] = 69;//Updating an array just like a variable

            string[] theBois = new string[3];
            theBois[0] = "Gonzalez";
            theBois[1] = "Bazzer";
            theBois[2] = "Garry";
            
            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(theBois[1]);

            Console.ReadLine();
        }
    }
}
