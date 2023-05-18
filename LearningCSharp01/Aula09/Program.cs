using System;
using System.Globalization;

namespace Aula09
{
    class program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vetor = new double[N];

            for (int i = 0; i < N; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vetor[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}