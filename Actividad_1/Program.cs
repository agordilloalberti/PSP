using System;
using System.Collections;
using System.Collections.Generic;
using Actividad_1.Entities;

namespace Actividad_1
{
    internal class Program
    {
        private static List<Character> characters;

        public static void Main(string[] args)
        {
            String userInput;
            Console.WriteLine("Bienvenido a \"Ultimate battle simulator\"");

            while (true)
            {
                Console.WriteLine("¿Cuantos jugadores van a jugar? (minimo de 2)");
                userInput = Console.ReadLine();
                try
                {
                    int n =int.Parse(userInput);
                    if (n>=2)
                    {
                        break;
                    }
                    Console.WriteLine("Deben haber un minimo de 2 jugadores");
                }
                catch (Exception)
                {
                    Console.WriteLine("El valor debe ser un numero, inserte de nuevo el número de jugadores");
                }
            }
            
            Console.WriteLine($"Perfecto, {userInput} jugadores, procedemos a crearlos"); 
            
            for (int i = 0; i < int.Parse(userInput); i++)
            {
                Console.WriteLine($"Procedemos con la creación del jugador {i}");
                createPlayer();
            }

            foreach (var c in characters)
            {
                char op;
                //TODO: arreglar el error con los tipos dentro del array
                Console.WriteLine($"Ahora vamos a equipar al personaje {c.getName}, ¿Espada(e) o hacha(h)?");
                op = Console.ReadLine().ToUpper()[0];
                
                while (op!='E' || op!='H')
                {
                    Console.WriteLine("Esa opción no es valida, Espada(e) o hacha()h");
                    op = Console.ReadLine().ToUpper()[0];
                }
            }
            
            //TODO: loop de batalla

        }

        
        
        private static void createPlayer()
        {
            char op;
            String nombre;
            double hp=0;
            double dmg=0;
            double armor=0;
            
            do
            {
                Console.WriteLine("Ingrese el nombre del jugador:");
                nombre = Console.ReadLine();
                Console.WriteLine($"{nombre}, ¿Es correcto? Y/N");
                op = Console.ReadLine().ToUpper()[0];
            } while (op != 'Y');

            do
            {
                Console.WriteLine("Ingrese la salud del jugador:");
                try
                {
                    hp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{hp} de salud, ¿Es correcto? Y/N");
                    op = Console.ReadLine().ToUpper()[0];
                }
                catch (Exception)
                {
                    Console.WriteLine("Escriba un número por favor\n");
                    op = 'N';
                }
            } while (op!='Y');
            
            do
            {
                Console.WriteLine("Ingrese el daño del jugador:");
                try
                {
                    dmg = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{dmg} de daño, ¿Es correcto? Y/N");
                    op = Console.ReadLine().ToUpper()[0];
                }
                catch (Exception)
                {
                    Console.WriteLine("Escriba un número por favor\n");
                    op = 'N';
                }
            } while (op!='Y');
            
            do
            {
                Console.WriteLine("Ingrese la armadura del jugador:");
                try
                {
                    armor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{armor} de armadura, ¿Es correcto? Y/N");
                    op = Console.ReadLine().ToUpper()[0];
                }
                catch (Exception)
                {
                    Console.WriteLine("Escriba un número por favor\n");
                    op = 'N';
                }
            } while (op!='Y');
            
            characters.Add(new Character(nombre,hp,dmg,armor));
        }
    }
}