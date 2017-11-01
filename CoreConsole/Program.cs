using System;
using CoreConsole.Entities;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier a = new Soldier(110, 75);

            Console.WriteLine("Hello World! The soldier has toughness of: " + a.Toughness.ToString());
            Console.ReadLine();
        }
    }
}