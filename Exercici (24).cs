/*Autor: Joaquin Alcazar
 * Data 05-11-2023
 * Exercici: 
 */

using System;

namespace UF1_Activitats
{
    public class Exercici24
    {
        public static void Main()
        {
            string name;
            string surname;
            string age;

            Console.WriteLine("Introdueix el teu nom");
            name = Console.ReadLine();

            Console.WriteLine("Introdueix el teu cognom");
            surname = Console.ReadLine();

            Console.WriteLine("Introdueix la teva edat");
            age = Console.ReadLine();

            Console.WriteLine($"En/La {name} {surname} te {age} anys");
        }
    }
}

