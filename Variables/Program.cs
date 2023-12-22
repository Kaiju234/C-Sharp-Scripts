using System;

namespace Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // intialization


            int y = 321; // Declaration + Intilization 

            int z = x + y;

            int age = 19; //whole integer
            double height = 5.11; //decimal number
            bool alive = false; // True or False
            char symbol = '@';
            String name = "Raj";
            Console.WriteLine("Hello" + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you Alive" + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;

            Console.WriteLine("your username is: " + userName);

            Console.ReadKey();
        }
    }
} 