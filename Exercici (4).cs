/*
 * Autor: Joaquín Alcazar
 * Data: 24/10/2023
 * Enunciat: Activitats
 */

using System;
using System.Timers;


namespace arrayEvensAndOdds
{
    class Exercici12
    {
        static void Main()
        {
            int[] arrayEven = new int[20];
            int[] arrayOdd = new int[20];

            int selectedNum;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("introdueix un nombre");
                selectedNum = Convert.ToInt32(Console.ReadLine());

                if (selectedNum % 2 == 0)
                {
                    arrayEven[i] = selectedNum;
                }
                if (selectedNum % 2 != 0)
                {
                    arrayOdd[i] = selectedNum;
                }
            }
            for (int i = 0; i < arrayEven.Length; i++)
            {
                if (arrayEven[i] != 0)
                {
                    {
                        Console.Write(arrayEven[i] + " ");
                    }
                }
            }
            Console.WriteLine("\n");
            for (int j = 0; j < arrayOdd.Length; j++)
            {
                if (arrayOdd[j] != 0)
                {

                    Console.Write(arrayOdd[j] + " ");

                }
            }
        }
    }
}
        