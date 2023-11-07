using System;
using System.Timers;

class wilsonsTheorem
{
    static void Main()
    {
        int selectedNumber;
        int wilsonTheorem=1;

        Console.WriteLine("Escriu un nombre per comprobar si es primer o no.");
        selectedNumber = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i  < selectedNumber; i++)
        {
            wilsonTheorem = wilsonTheorem * i;
        }
        wilsonTheorem = wilsonTheorem + 1; 
        if ((wilsonTheorem%selectedNumber) == 0)
        {
            Console.WriteLine(selectedNumber + " es un nombre primer");
        }
        else
        {
            Console.WriteLine(selectedNumber + " no es un nombre primer");
        }

    }
}