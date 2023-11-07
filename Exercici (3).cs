using System;
using System.Timers;

class evenSumAndOddSum
{
    static void Main()
    {
        int introducedNumber;
        int calculatingNumber;
        Console.WriteLine("Introdueix un nombre");
        introducedNumber = Convert.ToInt32(Console.ReadLine());
        int evenSum = 0;
        int oddSum = 0;
        calculatingNumber = introducedNumber;

        while (introducedNumber != 0)
        {
            calculatingNumber = introducedNumber%10;
            introducedNumber = introducedNumber/10;
            if (calculatingNumber%2 == 0) {
                evenSum = evenSum + calculatingNumber;
            } else
            {
                oddSum = oddSum + calculatingNumber;
            }
        }

        Console.WriteLine("La suma de les xifres parelles del nombre es: " + evenSum + " i la suma de les xifres senars es: " + oddSum);
    }
}