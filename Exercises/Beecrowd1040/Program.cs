using System;
using System.Globalization;

namespace Beecrowd1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');
            double N1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

            int peso1 = 2;
            int peso2 = 3;
            int peso3 = 4;
            int peso4 = 1;

            double media = (N1 * peso1 + N2 * peso2 + N3 * peso3 + N4 * peso4) / (peso1 + peso2 + peso3 + peso4);

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.00 && media < 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double mediaExame = (notaExame + media) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaExame >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
            }
            else
            {
                Console.WriteLine("Media: " + (media-0.01).ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}