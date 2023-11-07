/*
 * Autor: Joaquín Alcazar
 * Data: 30/10/2023
 * Enunciat: Activitats
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Timers;


namespace tenPersonArrays
{
    class Exercici19
    {
        static void Main()
        {
            int[] ageArray = new int[10];
            char[] sexArray = new char[10];
            decimal[] salaryArray = new decimal[10];
            bool[] becArray = new bool[10];

            int selectedNumber = 0;
            char selectedChar = '0';
            
            int selectedBool = 0;

            bool sexControl = false;
            bool becControl = false;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Introdiex la edat de persona " + (i + 1) + " (nombre enter)");
                    selectedNumber = Convert.ToInt32(Console.ReadLine());
                    if ((selectedNumber%1) == 0)
                    {
                        ageArray[i] = selectedNumber;
                    } else {
                        Console.WriteLine("Error, torna a introduir el valor");
                    }          
                } while ((ageArray[i]%1) != 0);

                do
                {
                    Console.WriteLine("Introdueix el Sexe de persona " + (i + 1) + " (H/D)");
                    selectedChar = Convert.ToChar(Console.ReadLine());
                    if (selectedChar == 'D' || selectedChar == 'd')
                    {
                        sexArray[i] = selectedChar;
                        sexControl = true;
                    } else if (selectedChar == 'H' || selectedChar == 'h')
                    {
                        sexArray[i] = selectedChar;
                        sexControl = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, torna a introduir el valor");
                        sexControl = false;
                    }

                } while (sexControl == false);

                Console.WriteLine("Introdueix el salari de persona " + (i + 1) + " ");
                salaryArray[i] = Convert.ToDecimal(Console.ReadLine());

                do
                {
                    Console.WriteLine("¿Es persona " + (i+1) + " un becari? (true=1/false=0)");
                    selectedBool = Convert.ToInt32(Console.ReadLine());
                    if (selectedBool == 1)
                    {
                        becArray[i] = true;
                        becControl = true;
                    }
                    else if (selectedBool == 0)
                    {
                        becArray[i] = false;
                        becControl = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, torna a introduir el valor");
                        becControl = false;
                    }


                    
                } while (becControl == false);

            }

            
            for (int j = 0; j < 10; j++)
            {
                Console.Write("Persona " + (j+1) + " ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("Edat: " + ageArray[j] + "  ");
            }
            Console.WriteLine("\n");
            for (int j = 0;j < 10; j++)
            {
                Console.Write("Sexe: " + sexArray[j] + "   ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("Salari:" + salaryArray[j] + " ");
            }
            Console.WriteLine("\n");
            for (int j = 0; (j < 10); j++)
            {
                Console.Write("Becari:" + becArray[j] + " ");
            }
        }
    }
}
        