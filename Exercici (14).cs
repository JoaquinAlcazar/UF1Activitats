using System;
using System.Timers;

class fibonacciSuccesion
{
    static void Main()
    {
        int firstNumber=1;
        int previousNumber=0;
        int howmany;
        int fibonacciNumber;

        Console.WriteLine("Insereix cuants numeros de la succesio de Fibonacci vols veure");
        howmany = Convert.ToInt32(Console.ReadLine());

        Console.Write("0 1 ");
        for (int i = 0; i < (howmany-2); i++)
        {
            fibonacciNumber = firstNumber + previousNumber;
            Console.Write(fibonacciNumber + " ");
            previousNumber = firstNumber;
            firstNumber = fibonacciNumber;
        }
    }
}