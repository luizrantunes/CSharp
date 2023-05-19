using System;
using System.Globalization;

namespace Aula10
{
    class program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int M = int.Parse(s1[0]);
            int N = int.Parse(s1[1]);
            int[,] A = new int[M, N];

            // esse primeiro for percorre as linhas
            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                // ja esse segundo for percorre as colunas
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            // esses dois for vão imprimir o resultado do que foi informado no ReadLine
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
            }
        }
    }
}