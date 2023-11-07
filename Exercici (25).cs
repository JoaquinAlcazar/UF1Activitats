/*Autor: Joaquin Alcazar
 * Data 05-11-2023
 * Exercici: Implementa un programa que emmagatzemi una frase introduïda per teclat en la variable textOne. 
 * Demana un altre text i emmagatzema’l en la variable textTwo. 
 * Afegeix textTwo a textOne i mostra-la per pantalla. 
 * És correcte? Què pots observar a les variables textOne i textTwo?
 */

using System;

namespace UF1_Activitats
{
    public class Exercici25
    {
        public static void Main()
        {
            string textOne;
            string textTwo;
            

            Console.WriteLine("Introdueix la frase per textOne");
            textOne = Console.ReadLine();

            Console.WriteLine("Introdueix la frase per textTwo");
            textTwo = Console.ReadLine();

            textOne += textTwo;
            //Les variables es concatenen, pero no hi deixen un espai entre variable i variable (a menys que li afegim maunalment en la introducció o en el WriteLine)
            Console.WriteLine(textOne);
        }
    }
}

