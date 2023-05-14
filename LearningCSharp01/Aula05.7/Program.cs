using System;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, notaC, pesoA, pesoB, pesoC, media;

            notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaC = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);


            pesoA = 2;
            pesoB = 3;
            pesoC = 5;

            media = (notaA * pesoA + notaB * pesoB + notaC * pesoC) / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}