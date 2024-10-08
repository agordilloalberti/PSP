using System;
using Actividad_1.Entities;

namespace Actividad_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Character A1 = new Character("Juan",10.0,5.0,0.0);
            Character A2 = new Character("Pepe",5.0,5.0,0.0);


            Console.WriteLine(A1.attack(A2));
            Console.WriteLine(A1.attack(A2));
            Console.WriteLine(A1.attack(A2));
            Console.WriteLine(A1.attack(A2));
        }
    }
}