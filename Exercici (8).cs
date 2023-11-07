using System;
using System.Timers;

class evenSumAndOddSum
{
    static void Main()
    {
        int sortir;
        Random rnd = new Random();
        int secretNumber = rnd.Next(0, 100);
        int selectedNumber;

        do
        {
            Console.WriteLine("Jugar o Sortir (0 per sortir/ cualsevol numero per jugar)");
            sortir = Convert.ToInt32(Console.ReadLine());

            if (sortir == 1)
            {
                do
                {
                    Console.WriteLine("Intenta adivinar un nombre entre 0 i 100");
                    selectedNumber = Convert.ToInt32(Console.ReadLine());
                        if (secretNumber == selectedNumber){
                            Console.WriteLine("Has adivinat el nombre secret. Has guanyat.");
                            sortir = 0;
                        } else if (secretNumber > selectedNumber){
                            Console.WriteLine("El nombre secret es mes gran que " + selectedNumber);
                        } else if (secretNumber < selectedNumber)
                        {
                            Console.WriteLine("El nombre secret es mes petit que " + selectedNumber);
                        }
                } while (secretNumber != selectedNumber);
                

            }
        } while (sortir != 0);
    }
}