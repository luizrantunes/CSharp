using System;
using System.Globalization;

namespace Aula10
{
    class program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);
            int[,] mat = new int[M, N];

            // esse primeiro for percorre as linhas
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');

                // ja esse segundo for percorre as colunas
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[M];

            for (int i = 0; i < M; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma += mat[i, j];
                }
                vet[i] = soma;
            }

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}