using System;
using System.Timers;

class evenSumAndOddSum
{
    static void Main()
    {
        decimal nota;

        Console.WriteLine("Insereix la nota (En format decimal (0.0))");
        nota = Convert.ToDecimal(Console.ReadLine());

        if (nota < 5 ) 
        {
            Console.WriteLine("Suspès");
        } else if (nota == 5 ) 
        {
            Console.WriteLine("Suficient");
        } else if (nota == 6)
        {
            Console.WriteLine("Bé");
        } else if (nota == 7 || nota == 8)
        {
            Console.WriteLine("Notable");
        } else if(nota == 9 || nota == 10)
        {
            Console.WriteLine("Excel·lent");
        } else if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota invàlida");
        }
    }
}