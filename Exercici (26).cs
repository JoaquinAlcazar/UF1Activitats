/*Autor: Joaquin Alcazar
 * Data 05-11-2023
 * Exercici: Implementa un programa que demani a 
 * l’usuari que introdueixi un text i retorni la seva longitud.
 */

using System;

namespace UF1_Activitats
{
    public class Exercici26
    {
        public static void Main()
        {
            string textOne;
            
            Console.WriteLine("Introdueix una frase");
            textOne = Console.ReadLine();

            Console.WriteLine("La frase te " + textOne.Length + " caracters");
        }
    }
}

