using System;
using System.Timers;

class weekDay
{
    static void Main()
    {
        int day;

        Console.WriteLine("Insereix el número corresponent al dia de la setmana (1-7)");
        day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Dilluns");
                break;
            case 2:
                Console.WriteLine("Dimarts");
                break;
            case 3:
                Console.WriteLine("Dimecres");
                break;
            case 4:
                Console.WriteLine("Dijous");
                break;
            case 5:
                Console.WriteLine("Divendres");
                break;
            case 6:
                Console.WriteLine("Dissabte");
                break;
            case 7:
                Console.WriteLine("Diumenge");
                break;
        }

    }
}