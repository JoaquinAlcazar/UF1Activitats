/*
 * Autor: Joaquín Alcazar
 * Data: 24/10/2023
 * Enunciat: Activitats
 */

using System;
using System.Timers;


namespace leftToRightArray
{
    class Exercici14
    {
        static void Main()
        {
            int[] arrayLeftRight = new int[20];
            int selectedNumber;
            for (int i = 0; i < arrayLeftRight.Length;)
            {
                Console.WriteLine("Introdueix un nombre entre 1 i 9 (1 i 9 inclosos)\nnumero " + (i+1));
                selectedNumber = Convert.ToInt32(Console.ReadLine());

                if (selectedNumber > 0 && selectedNumber < 10)
                {
                    arrayLeftRight[i] = selectedNumber;
                    i++;
                } else 
                { 
                    Console.WriteLine("Numero fora de rang, torna a introduir un nombre!!");
                }
            }

            for (int i = 0;i < arrayLeftRight.Length; i++)
            {
                Console.Write(arrayLeftRight[i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = arrayLeftRight.Length - 1; i >= 0; i--) 
            {
                Console.Write(arrayLeftRight[i] + " ");
            }
        }
    }
}
        