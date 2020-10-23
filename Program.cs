using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your quest?");
            string quest = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine(name + " approaches the bridge keeper.  He tells the bridge keeper "
                + "\"My name is " + name + ", My quest is: " + quest + ", and my favorite color is "
                + color + ". Now let me pass or I shall bite my thumb at you.\"");
        }
    }
}