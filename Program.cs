using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human devon = new Human("Devon");
            Human taylor = new Human("Taylor", 5, 5, 5, 90);
            string x = "x";

            devon.attack(taylor);
            taylor.attack(x);
        }
    }
}
