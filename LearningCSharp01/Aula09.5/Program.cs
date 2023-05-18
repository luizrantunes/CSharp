using System;
using System.Globalization;

namespace Aula09
{
    class program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] vetor = new string[N];

            for (int i = 0; i < N; i++)
            {
                vetor[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");

            foreach (string nome in vetor)
            {
                Console.WriteLine(nome);
            }
        }
    }
}