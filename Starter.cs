using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Starter
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the practice hub. Which class would you like to run?\n");
            Console.WriteLine("YOUR OPTIONS:\n" +
                              "1 - User Input Class\n" +
                              "2 - Gibberish (Practice with data types)\n" +
                              "3 - Calculator\n" +
                              "4 - Mad Libs\n" +
                              "5 - Arrays\n" +
                              "6 - Methods\n" +
                              "7 - Return Statments\n" +
                              "8 - If Statements\n" +
                              "9 - Max Number Comparison (More If Statements)\n" +
                              "10 - A Better Calculator" +
                              "11 - Inheritance through animals");

            Console.Write("Enter your choice here: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("\n\n================= ERROR ===================\n\n");
                Console.WriteLine("Invalid option. Please exit and try again.");
                Console.ReadLine();
            }

            if (n == 1)
            {
                Console.WriteLine("\n\n================= USER INPUT ===================\n\n");
                UserInput.Input();
            }

            else if (n == 2)
            {
                Console.WriteLine("\n\n================= GIBBERISH ===================\n\n");
                Basics.BasicsMethod();
            }

            else if (n == 3)
            {
                Console.WriteLine("\n\n================= CALCULATOR ===================\n\n");
                Calculator.Calc();
            }

            else if (n == 4)
            {
                Console.WriteLine("\n\n================= MAD LIBS ===================\n\n");
                MadLibs.CreateMadLib();
            }

            else if (n == 5)
            {
                Console.WriteLine("\n\n================= ARRAYS ===================\n\n");
                Arrays.ArrayMethod();
            }

            else if (n == 6)
            {
                Console.WriteLine("\n\n================= METHODS ===================\n\n");
                Methods.MethodCont();
            }

            else if (n == 7)
            {
                Console.WriteLine("\n\n================= RETURN STATEMENTS ===================\n\n");
                ReturnStatements.ReturnMain();
            }

            else if (n == 8)
            {
                Console.WriteLine("\n\n================= IF STATEMENTS ===================\n\n");
                IfStatments.IfMain();
            }

            else if (n == 9)
            {
                Console.WriteLine("\n\n================= MAX NUMBER COMPARISON ===================\n\n");
                IfNumComparison.CompMain();
            }

            else if (n == 10)
            {
                Console.WriteLine("\n\n================= BETTER CALCULATOR ===================\n\n");
                BetterCalc.CalcMain();
            }

            else if (n == 11)
            {
                Console.WriteLine("\n\n================= INHERITANCE ===================\n\n");
                InheritMain.AniMain();
            }

            else
            {
                Console.WriteLine("\n\n================= ERROR ===================\n\n");
                Console.WriteLine("Invalid option. Please exit and try again.");
                Console.ReadLine();
            }
            
        }
    }
}
