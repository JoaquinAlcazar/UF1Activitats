/*
 * Autor: Joaquín Alcazar
 * Data: 30/10/2023
 * Enunciat: Activitats
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Timers;


namespace ascendDescendShow
{
    class Exercici23
    {
        static void Main()
        {
            int selectedNum;
            int[] marks = new int[20];
            

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Introdueix la nota " + (i+1));
                selectedNum = Convert.ToInt32(Console.ReadLine());
                marks[i] = selectedNum;
            }

            

            for (int i = 0;i < marks.Length-1;i++) 
            {
                for (int j = i+1; j < marks.Length;j++)
                {
                    if (marks[i] > marks[j])
                    {
                        int aux = marks[i];
                        marks[i] = marks[j];
                        marks[j] = aux;
                    }
                }
            }

            int ascenDescen = 0;
            Console.WriteLine("Vols veure els resultats en ordre ascendent (1) o descendent (2)?");
            do
            {
                ascenDescen = Convert.ToInt32(Console.ReadLine());
                if (ascenDescen == 1)
                {
                    for (int i = 0; i < marks.Length; i++)
                    {
                        Console.Write(marks[i] + " ");
                    }
                }
                else if (ascenDescen == 2)
                {
                    Console.WriteLine();
                    for (int i = marks.Length - 1; i >= 0; i--)
                    {
                        Console.Write(marks[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Error, torna a introduir el valor.");
                }
            } while (ascenDescen > 2 || ascenDescen < 1);
                         
        }
    }
}
        