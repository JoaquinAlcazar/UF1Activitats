using System;
using System.Timers;

class anyTrespas
{
    static void Main()
    {
        int introducedYear;
        Console.WriteLine("Introdueix un any");
        introducedYear = Convert.ToInt32(Console.ReadLine());

        if ((introducedYear%4) == 0)
        {
            Console.WriteLine("Aquest any es un any de trespás");
        } else {
            Console.WriteLine("Aquest any no es un any de trespás");
        }
    }
}