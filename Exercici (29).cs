﻿/*Autor: Joaquin Alcazar
 * Data 05-11-2023
 * Exercici: Fent servir la interpolació, implementa un programa que mostri el contingut del jagged array
 */

using System;
using System.Globalization;

namespace UF1_Activitats
{
    public class Exercici29
    {
        public static void Main()
        {
            int[][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[] { 1, 2, 3, 4 };
            jaggedArr[1] = new int[] { 11, 34, 67 };
            jaggedArr[2] = new int[] { 89, 23 };
            jaggedArr[3] = new int[] { 0, 45, 78, 53, 99 };


            for (int i = 0; i < 4; i++)
            {
                Console.Write("Fila " + i + ": ");
                for (int j = 0; j < jaggedArr[i].Length; j++) 
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}

