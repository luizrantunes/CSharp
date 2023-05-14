using System;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, pesoA, pesoB, media;

            notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pesoA = 3.5;
            pesoB = 7.5;

            media = (notaA * pesoA + notaB * pesoB) / (pesoA + pesoB);

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}