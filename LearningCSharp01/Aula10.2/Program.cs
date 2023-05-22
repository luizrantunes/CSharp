using System;
using System.Globalization;

namespace Aula10
{
    class program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, N];

            // esse primeiro for percorre as linhas
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                // ja esse segundo for percorre as colunas
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
        }
    }
}