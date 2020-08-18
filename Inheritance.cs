using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class InheritMain
    {
        //BASE CLASS - Defining general animal traits
        public class Animal
        {
            public string name;
            public int age;
            public double happiness;

            public void PrintBase()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
            }
        }

        //DERIVED CLASSES - Inheriting from the base class and adding more specific traits
        //Dog inherits from Animal
        class Dog : Animal 
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("WOOF!");
                base.happiness += 0.1;//Verifying that the happiness is from the base class, and incremementing it when the dog barks
            }
        }

        //Cat inherits from Animal
        class Cat : Animal 
        {
            public double cuteness;

            public void Meow()
            {
                Console.WriteLine("MEOW!");
            }
        }


        //Creating instances
        public static void AniMain()
        {
            //An instance of Dog
            Dog clyde = new Dog();
            clyde.name = "Clyde";
            clyde.age = 3;
            clyde.happiness = 0.8;
            clyde.spotCount = 1;
            clyde.Bark();

            //An instance of Cat
            Cat garfield = new Cat();
            garfield.name = "Garfield";
            garfield.age = 13;
            garfield.happiness = 0.2;
            garfield.cuteness = 1.0;
            garfield.Meow();

            Console.ReadLine();



        }

    }
    
}
