using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Aula07
{
    class program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            int z = int.Parse(valores[2]);

            if (x < y && x < z) {
                Console.WriteLine("MENOR = " + x);
            }
            else if (y < z) {
                Console.WriteLine("MENOR = " + y);
            } else
                Console.WriteLine("MENOR = " + z);
        }
    }
}