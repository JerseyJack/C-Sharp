using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class Methods
    {
        public static void MethodCont()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("And your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            SayHi(name, age);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Wassup, " + name + ". Who is also " + age + " years old...");
        }
    }
}
