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
            List<Item> items = new List<Item>();
            items.Add(new Axe());
            items.Add(new Shield());
            
            List<Item> items2 = new List<Item>();
            items2.Add(new Sword());
            items2.Add(new Helmet());
            
            List<Pet>pets = new List<Pet>();
            pets.Add(new Pet("Lukos",5));
            
            Character A1 = new Character("Juan",10.0,5.0,0.0,items,pets);
            Character A2 = new Character("Pepe", 10.0, 5.0, 0.0, items2);
            
            Console.WriteLine(A1);
            Console.WriteLine(A2);
            
            Console.WriteLine(A1.attack(A2));

        }
    }
}