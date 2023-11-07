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
            int[] hpArray = new int[4];
            int[] powerArray = new int[4];
            int[] forceArray = new int[4];

            for (int i = 0; i < 4; i++) 
            {
                do { 
                    Console.WriteLine("Introdueix la vida del personatje " + (i+1) + " [1-1000]");
                    hpArray[i] = Convert.ToInt32(Console.ReadLine());
                    if (hpArray[i] < 1 || hpArray[i] > 1000)
                    {
                        Console.WriteLine("Error, torna a introduir el valor");
                    } 
                }while (!(hpArray[i] >= 1 && hpArray[i] <= 1000));

                do 
                {
                    Console.WriteLine("Introdueix el poder del personatje " + (i + 1) + " [100-500]");
                    powerArray[i] = Convert.ToInt32(Console.ReadLine());
                    if (powerArray[i] < 100 || powerArray[i] > 500)
                    {
                        Console.WriteLine("Error, torna a introduir el valor");
                    }
                } while (!(powerArray[i] >= 100 && powerArray[i] <= 500));

                do 
                { 
                    Console.WriteLine("Introdueix la força del personatje " + (i + 1) + " [20-50]");
                    forceArray[i] = Convert.ToInt32(Console.ReadLine());
                    if (forceArray[i] < 20 || forceArray[i] > 50)
                    {
                        Console.WriteLine("Error, torna a introduir el valor");
                    }
                } while (!(forceArray[i] >= 20 && forceArray[i] <= 50));

            }   

            for (int j = 0; j < 4; j++) 
            {
                Console.Write("Personatje " + (j+1) + "    ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(hpArray[j] + "          ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(powerArray[j] + "            ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(forceArray[j] + "              ");
            }
            Console.WriteLine("\n");

        }
    }
}
        