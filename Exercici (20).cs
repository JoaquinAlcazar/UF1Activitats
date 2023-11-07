/*
 * Autor: Joaquín Alcazar
 * Data: 30/10/2023
 * Enunciat: Activitats
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Timers;


namespace numberArrangement
{
    class Exercici20
    {
        static void Main()
        {
            int selectedNumber;
            int[,] array = new int[7,3];
            
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Introdueix el numero " + (i+1) + "_" + (j+1) + ". Ha de ser un nombre entre 1 i 9 (1 i 9 inclosos)");
                    do
                    {
                        selectedNumber = Convert.ToInt32(Console.ReadLine());
                        if(selectedNumber > 9 || selectedNumber < 0)
                        {
                            Console.WriteLine("Numero fora del rang, torna a introduirlo");
                        } else
                        {
                            array[i, j] = selectedNumber;
                        }
                    } while (selectedNumber > 9 || selectedNumber < 1);
                }
            }

            for (int j = 0; j < 7; j++)
            {
                Console.Write(array[j,0]);                  
            }
            Console.WriteLine("");
            for (int j = 0; j < 7; j++)
            {
                Console.Write(array[j, 1]);
            }
            Console.WriteLine("");
            for (int j = 0; j < 7; j++)
            {
                Console.Write(array[j, 2]);
            }

        }
    }
}
        