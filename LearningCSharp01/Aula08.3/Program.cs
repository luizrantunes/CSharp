using System;
using System.Globalization;

namespace Aula08
{
    class program
    {
        static void Main(string[] args)
        {
            double idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double soma = 0.0;
            double media;
            int cont = 0;


            while (idade >= 0)
            {
                soma += idade;
                cont ++;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}