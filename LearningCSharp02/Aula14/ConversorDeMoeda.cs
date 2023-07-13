using System;
using System.Globalization;

namespace Aula14
{
    internal class ConversorDeMoeda
    {
        public static double Dolar;
        public static double Quantidade;

        public static double ValorCotacao()
        {
            return (Quantidade * Dolar) + (Quantidade * Dolar * 0.06);
        }
    }
}
