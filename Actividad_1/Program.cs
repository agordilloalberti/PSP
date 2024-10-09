using System;
using System.Collections.Generic;
using Actividad_1.Entities;
using Actividad_1.Items.Protections;
using Actividad_1.Items.Weapons;

namespace Actividad_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Character A1 = new Character("Juan",10.0,5.0,0.0);
            Character A2 = new Character("Pepe", 10.0, 5.0, 0.0);
            
            A1.addWeapon(new Axe());
            A1.addProtection(new Shield());
            A1.addPet(new Pet("Lukos",10));
            
            A2.addWeapon(new Sword());
            A2.addProtection(new Helmet());
            A2.heal(5);

            Console.WriteLine(A1.seeInventory());

            // Console.WriteLine(A1.attack(A2));
            // Console.WriteLine(A2.attack(A1));
            // Console.WriteLine(A1.attack(A2));
            // Console.WriteLine(A2.attack(A1));

        }
    }
}