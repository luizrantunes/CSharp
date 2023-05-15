using System;
using System.Globalization;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotal = int.Parse(Console.ReadLine());
            double combustivelTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumoMedio = (double) distanciaTotal / combustivelTotal;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}