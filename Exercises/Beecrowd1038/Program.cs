using System;
using System.Globalization;

namespace Beecrowd1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');
            int lanche = int.Parse(dados[0]);
            int quantidade = int.Parse(dados[1]);
            double valor = 0.00;
            double valorTotal = 0.00;

            if (lanche == 1)
            {
                valor = 4.00;
                valorTotal = valor * quantidade;
            }
            else if (lanche == 2)
            {
                valor = 4.50;
                valorTotal = valor * quantidade;
            }
            else if (lanche == 3)
            {
                valor = 5.00;
                valorTotal = valor * quantidade;
            }
            else if (lanche == 4)
            {
                valor = 2.00;
                valorTotal = valor * quantidade;
            }
            else if (lanche == 5)
            {
                valor = 1.50;
                valorTotal = valor * quantidade;
            }
            else
                Console.WriteLine("Produto e quantidade invalidos");

            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}