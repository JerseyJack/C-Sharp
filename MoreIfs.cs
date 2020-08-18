using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class IfNumComparison
    {
        public static void CompMain()
        {
            Console.WriteLine(GetMax(6, 9, 7));
            Console.ReadLine();
        }

        static int GetMax(int n1, int n2, int n3)
        {
            int result;

            if (n1 >= n2 && n1 >= n3)
            {
                result = n1;
            }

            else if (n2 >= n1 && n2 >= n3)
            {
                result = n2;
            }

            else
            {
                result = n3;
            }

            return result;
        }
    }
}
