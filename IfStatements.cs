using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class IfStatments
    {
        public static void IfMain()
        {

            bool isMale = true;
            bool isTall = false;

            /*
            Console.Write("Are you a male?\n\nY - Yes\nN - No\n\n");
            string answer = Console.ReadLine();
            */

            if (isMale && isTall)//AND - both have to be true
            {
                Console.WriteLine("Well done, you're a tall guy");
            }

            else if (isMale && !isTall)//Male but not tall
            {
                Console.WriteLine("Well done, you're a short guy");
            }

            else if (!isMale && isTall)//Not male but tall
            {
                Console.WriteLine("Well done, you're a tall wahmen");
            }

            else if (!isMale && !isTall)//Not male not tall
            {
                Console.WriteLine("Well done, you're a short wahmen");
            }

            /*
            else if (isMale || isTall)//OR - only one has to be true
            {
                Console.WriteLine("Well done, you're either a short guy, or a tall gal");
            }
            */

            else
            {
                Console.WriteLine("Well done, you don't exist");
            }

            Console.ReadLine();
        }
    }
}
