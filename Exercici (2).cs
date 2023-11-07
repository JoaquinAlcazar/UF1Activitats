using System;
using System.Timers;

class numbersBetween2000And3000
{
    static void Main()
    {
        int minimum = 2000;
        int maximum = 3000;
        int actual = 2000;
        int actualDivisible;

        do
        {
            if ((actual % 7) == 0)
            {
                if ((actual % 5) == 0)
                {
                    actualDivisible = 1;
                }
                actualDivisible = 0;
            } else {
                actualDivisible = 1;
            }

            if (actualDivisible == 0)
            {
                Console.Write(actual);
                if (actual != 2996)
                {
                    Console.Write(", ");
                }
            }

            
            actual++;
        } while (actual != 3000);
    }
}