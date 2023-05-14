using System;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, raio, area;

            n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (raio * raio) * n;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}