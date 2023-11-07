using System;
using System.Timers;

class factorialFinding
{
    static void Main()
    {
        int selectedNumber;
        int factorializing=1;

        Console.WriteLine("Insereix un nombre per trobar el seu factorial");
        selectedNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= selectedNumber; i++)
        {
            factorializing = factorializing * i;
        }
        Console.WriteLine("El factorial de " + selectedNumber + " es " + factorializing);

    }
}