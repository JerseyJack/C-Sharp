using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class UserInput
    {
        public static void Input()
        {
            Console.WriteLine("Greetings traveller");
            Console.Write("What is thy name? \n");
            string name = Console.ReadLine();

            Console.WriteLine("Well hello there, " + name + ".");
            Console.Write("Please, tell me how old you are... \n");
            string age = Console.ReadLine();

            Console.WriteLine("Ah! " + age + "! Quite the young whipper-snapper aren't we?");
            Console.ReadLine();
        }
    }
}
