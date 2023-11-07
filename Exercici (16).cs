/*
 * Autor: Joaquín Alcazar
 * Data: 25/10/2023
 * Enunciat: Activitats
 */

using System;
using System.Timers;


namespace invertedArray
{
    class Exercici16
    {
        static void Main()
        {

            int[] array = new int[10];

             for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introdueix un nombre (nombre " + (i+1) + ")");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

             for (int j = array.Length-1;j > -1; j--) 
            {
                Console.Write(array[j] + " ");
            }


        }
    }
}
        