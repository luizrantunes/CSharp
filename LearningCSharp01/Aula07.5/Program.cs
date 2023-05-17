using System;
using System.Globalization;

namespace Aula07
{
    class program {
        static void Main(string[] args) {
            int minutos = int.Parse(Console.ReadLine());
            double plano = 50.00;

            if (minutos > 100) {
                plano += (minutos - 100) * 2;
                Console.WriteLine("Valor a pagar: R$ " + plano.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Valor a pagar: R$ " + plano.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}