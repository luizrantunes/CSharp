using System;
using System.Globalization;

namespace Aula08
{
    class program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int x = int.Parse(numeros[0]);
            int y = int.Parse(numeros[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                numeros = Console.ReadLine().Split(' ');
                x = int.Parse(numeros[0]);
                y = int.Parse(numeros[1]);
            }
        }
    }
}