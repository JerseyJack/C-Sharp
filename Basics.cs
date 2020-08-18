using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class Basics
    {
        public static void BasicsMethod()
        {
            // =====================UPDATING VARIABLES===================
            string name = "Jeff";
            string place = "home";
            int age = 33;

            Console.WriteLine("Ma name a " + name + ".");
            Console.WriteLine("You can find me at " + place + ".");
            Console.WriteLine("I am " + age + " years old.");

            name = "Samwise";
            Console.WriteLine("Now my name is " + name + ". Wow, amazing right?");
            Console.ReadLine();
            

            // =====================DATA TYPES======================
            //Letter data types
            string phrase = "Mama cita";
            char grade = 'A'; //This can only hold one single character. Use single apostrophes

            //Number data types
            int num = 69; //Whole number
            decimal measurement = 3.4113351m; //Very accurate number that requires suffix
            double precise = 2.13521367324352; //Precise number, requires no suffix, can hold up to 15 digits (RECOMMENDED TO USE THIS ONE)
            float semiPrecise = 6.9f; //Not very precise decimal number that can take one decimal number, requires f suffix

            //Boolean
            bool isMale = true; //True or false data type

            //Constants - dont always need variables, can just be printed
            Console.WriteLine("Hello there"); //String constant
            Console.WriteLine(69); //Integer constant
            

            // ====================STRING METHODS=======================
            phrase = "Oh yeah" + ", it's all coming together"; //Concatenation - essentially adding two strings together
            Console.WriteLine(phrase);

            Console.WriteLine(phrase.Length); //Finding out a little info on the string

            //Using string methods to modify them
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());

            //Checking if it contains something
            Console.WriteLine(phrase.Contains("together"));

            //String indexing
            Console.WriteLine(phrase[10]);//Print letter in the indexed position
            Console.WriteLine(phrase.IndexOf("all"));//Print the index position of the first letter of the given string. If it doesn't exist, the console will return -1

            //Printing substrings
            Console.WriteLine(phrase.Substring(18, 6));//Substring(index position, length)
            Console.WriteLine(phrase.Substring(phrase.IndexOf("coming")));//Makes a substring of characters after the indexed phrase

            Console.ReadLine();
            

            //====================NUMBER AND MATH METHODS==================
            //Number constant
            Console.WriteLine(50 + " is just a number");
            //Some maths and OPERATORS
            Console.WriteLine(23 + 27);//Addition
            Console.WriteLine(23 - 27);//Subtraction
            Console.WriteLine(23 * 27);//Multiplication
            Console.WriteLine(23 / 27);//Division
            Console.WriteLine(23 % 27);//Modulus, does devision then gets the remainder
            Console.WriteLine(23 + 27 * 5);//This will use normal order of equations, for example, multiplication comes first
            Console.WriteLine((23 + 27) * 5);//The above order, however, can be changed using brackets, again like normal maths

            //Doing calculations with different types
            Console.WriteLine(23 + 27);//If it is only integers, you will get an intege answer
            Console.WriteLine(23 + 27.3);//If there is a decimal number in the mix, then the answer will be decimal

            //Storing a number in a variable
            int x = 10;
            Console.WriteLine(x);

            //Incrementing a number
            x++;
            Console.WriteLine(x);

            //Decrementing a number
            x--;
            Console.WriteLine(x);

            //Caling Math methods
            Console.WriteLine(Math.Abs(-10));//Gives the absolute value of -10
            Console.WriteLine(Math.Pow(3.4, 4));//Gives the power of the number, Pow(number, power)
            Console.WriteLine(Math.Sqrt(36));//Gives the square root of a number
            Console.WriteLine(Math.Max(4, 5));//Gives the bigger of the two numbers
            Console.WriteLine(Math.Min(4, 5));//Gives the smaller of the two number
            Console.WriteLine(Math.Round(5.6));//Rounds up to the nearest whole number

            Console.ReadLine();



        }
    }
}
