/*
 * Autor: Joaquín Alcazar
 * Data: 25/10/2023
 * Enunciat: Activitats
 */

using System;
using System.Timers;


namespace leftToRightArray
{
    class Exercici15
    {
        static void Main()
        {
            int arrayLength;
            int totalSum=0;
            Console.WriteLine("Quants espais vols tenir a l'array?");
            arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Insereix un nombre enter (nombre " + (i+1) + ")");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < arrayLength; i++)
            {
                totalSum = totalSum + array[i];
            }

            Console.WriteLine(totalSum);
        }
    }
}
        