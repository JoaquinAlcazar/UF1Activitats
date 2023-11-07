/*Autor: Joaquin Alcazar
 * Data 05-11-2023
 * Exercici: Fent servir la interpolació i l’operador ternari, 
 * implementa un programa que indiqui pels 20 primers nombres (del 1 al 20 inclosos) si és parell o senar 
 * (només ha d’indicar per a cada valor “És parell”/”És senar)”.
 */

using System;
using System.Globalization;

namespace UF1_Activitats
{
    public class Exercici28
    {
        public static void Main()
        {
            for (int i = 1; i <= 20; i++) {
                Console.Write(i + ": ");
                Console.WriteLine((i%2==0) ? "Parell" : "Senar");

            }
        }
    }
}

