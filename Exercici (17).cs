/*
 * Autor: Joaquín Alcazar
 * Data: 25/10/2023
 * Enunciat: Activitats
 */

using System;
using System.Timers;


namespace comprobationArray
{
    class Exercici16
    {
        static void Main()
        {
            int arrayLength;
            int totalSum=0;
            float selectedNum;
            int selectedInt;
            int arrayCounter = 0;
            int tries = 0;
            int lessThan15Counter = 0;
            int moreThan30Counter = 0;

            Console.WriteLine("Quants espais vols tenir a l'array?");
            arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arrayLength];
            while (arrayCounter < arrayLength && tries < 3)
            {
                Console.WriteLine("Insereix un nombre natural (nombre " + (arrayCounter+1) + ")");
                selectedNum = Convert.ToInt32(Console.ReadLine());
                if (selectedNum%1 == 0)
                {
                    selectedInt = Convert.ToInt32(selectedNum);
                    array[arrayCounter] = selectedInt;
                    arrayCounter++;
                    tries = 0;
                }
                else
                {
                    Console.WriteLine("Error, torna a introduir un nombre natural");
                    tries++;
                    Console.WriteLine("Has utilitzat " + tries + "intents");
                }
            }

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] < 15)
                {
                    lessThan15Counter++;
                }
                if (array[i] > 30)
                {
                    moreThan30Counter++;
                }
            }

            Console.WriteLine("El nombre de valors introduits al array es de " + arrayLength + " valors.\nEl nombre de valor mes petits de 15 es de " + lessThan15Counter + "\ni el nombre de valors mes grans de 30 es de " + moreThan30Counter);
        }
    }
}
        