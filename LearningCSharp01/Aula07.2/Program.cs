﻿using System;
using System.Globalization;

namespace Aula07
{
    class program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = nota1 + nota2;

            if (notaFinal < 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}