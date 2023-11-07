using System;
using System.Timers;

class tresNombresEnters
{
    static void Main()
    {
        int minimum;
        int maximum;
        int insideMinMax;

        Console.WriteLine("Introdueix un valor de minim");
        minimum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdueix un valor de maxim");
        maximum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdueix un valor entre el minim i el maxim");
        insideMinMax = Convert.ToInt32(Console.ReadLine());

        if((insideMinMax > minimum) && (insideMinMax < maximum))
        {
            Console.WriteLine("El numero introduit es troba entre el valor minim i el valor maxim");
        } else
        {
            Console.WriteLine("El numero introduit es fora del rang entre el valor minim i el valor maxim");
        }
    }
}