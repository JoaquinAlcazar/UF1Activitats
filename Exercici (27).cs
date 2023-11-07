/*Autor: Joaquin Alcazar
 * Data 05-11-2023
 * Exercici: Implementa un programa que demani a l’usuari que introdueixi un text i el retorni tot en majúscules, 
 * tot en minúscules i la primera lletra de cada paraula en majúscules (per separat).
 */

using System;
using System.Globalization;

namespace UF1_Activitats
{
    public class Exercici27
    {
        public static void Main()
        {
            string textOne;
            char[] userTextOne;

            Console.WriteLine("Introdueix una frase");
            textOne = Console.ReadLine();
            userTextOne = textOne.ToCharArray();

            Console.WriteLine(textOne.ToUpper());
            Console.WriteLine(textOne.ToLower());


            for (int i=0; i < userTextOne.Length-1; i++)
            TextInfo textInfo = new CultureInfo("es-ES", false).TextInfo;
            Console.WriteLine(textInfo.ToTitleCase(textOne));
        }
    }
}

