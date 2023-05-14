using System;
using System.Globalization;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pessoaUm = Console.ReadLine().Split(' ');
            string nomeUm = pessoaUm[0];
            int idadeUm = int.Parse(pessoaUm[1]);

            string[] pessoaDois = Console.ReadLine().Split(' ');
            string nomeDois = pessoaDois[0];
            int idadeDois = int.Parse(pessoaDois[1]);

            double media = (double) (idadeUm + idadeDois) / 2;

            Console.WriteLine("A idade média de " + nomeUm + " e " +  nomeDois + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");
        }
    }
}