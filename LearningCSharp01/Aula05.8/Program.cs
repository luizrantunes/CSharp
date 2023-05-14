using System;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC, valorD, DIFERENCA;

            valorA = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorB = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorC = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorD = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            DIFERENCA = (valorA * valorB) - (valorC * valorD);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}