/*
 * Autor: Joaquín Alcazar
 * Data: 24/10/2023
 * Enunciat: Activitats
 */

using System;
using System.Timers;


namespace arrayUnevenSpaces
{
    class Exercici13
    {
        static void Main()
        {
            int[] arrayIntegers = new int[20];

            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                Console.WriteLine("Introdueix un nombre");
                arrayIntegers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < arrayIntegers.Length; i=i+2)
            {

                Console.WriteLine(arrayIntegers[i]);
            }
        }
    }

}