using System;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhaUm = Console.ReadLine().Split(' ');
            int codigoPecaUm = int.Parse(linhaUm[0]);
            int numeroPecasUm = int.Parse(linhaUm[1]);
            double valorUnitarioPecaUm = double.Parse(linhaUm[2], CultureInfo.InvariantCulture);

            string[] linhaDois = Console.ReadLine().Split(' ');
            int codigoPecaDois = int.Parse(linhaDois[0]);
            int numeroPecasDois = int.Parse(linhaDois[1]);
            double valorUnitarioPecaDois = double.Parse(linhaDois[2], CultureInfo.InvariantCulture);

            double valorTotal = (numeroPecasUm * valorUnitarioPecaUm) + (numeroPecasDois * valorUnitarioPecaDois);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}