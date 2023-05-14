using System;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double triangulo = (valorA * valorC) / 2;
            double circulo = (valorC * valorC) * pi;
            double trapezio = ((valorA + valorB) * valorC) / 2;
            double quadrado = valorB * valorB;
            double retangulo = valorA * valorB;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}