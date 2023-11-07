﻿/*
 * Autor: Joaquín Alcazar
 * Data: 30/10/2023
 * Enunciat: Activitats
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Timers;


namespace valueSearching
{
    class Exercici22
    {
        static void Main()
        {
            int selectedNum;
            int[] marks = new int[20];
            int selectedSearch;
            int searching = 0;
            bool found = false;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Introdueix la nota " + (i+1));
                selectedNum = Convert.ToInt32(Console.ReadLine());
                marks[i] = selectedNum;
            }

            Console.WriteLine("¿Quin valor vols cercar?");
            selectedSearch = Convert.ToInt32(Console.ReadLine());
            while (found = false && searching < marks.Length-1) 
            {
                
                if (marks[searching] == selectedSearch)
                {
                    found = true;
                }
                searching++;
            }

            if (found = false)
            {
                Console.WriteLine("Aquest valor no es troba entre les notes");
            } else if (found = true)
            {
                Console.WriteLine("Aquest valor es troba entre les notes");
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

            for (int i = 0; i< marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
            for (int i = marks.Length-1; i >= 0; i--)
            {
                Console.Write(marks[i] + " ");
            }
            
        }
    }
}
        