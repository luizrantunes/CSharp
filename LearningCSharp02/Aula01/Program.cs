using System;
using System.Globalization;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] info1 = Console.ReadLine().Split(' ');
            int peca1 = int.Parse((info1[0]));
            int numeroPeca1 = int.Parse((info1[1]));
            double valorPeca1 = double.Parse((info1[2]), CultureInfo.InvariantCulture);

            string[] info2 = Console.ReadLine().Split(' ');
            int peca2 = int.Parse((info2[0]));
            int numeroPeca2 = int.Parse((info2[1]));
            double valorPeca2 = double.Parse((info2[2]), CultureInfo.InvariantCulture);

            double total1 = numeroPeca1 * valorPeca1;
            double total2 = numeroPeca2 * valorPeca2;

            double total = total1 + total2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}