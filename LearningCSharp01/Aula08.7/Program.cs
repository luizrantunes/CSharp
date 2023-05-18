using System;
using System.Globalization;

namespace Aula08
{
    class program
    {
        static void Main(string[] args)
        {
            char repetir;
            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                double celcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double fahhrenheit = 9.0 * celcius / 5 + 32.0;
                Console.WriteLine("Equivalente a Fahrenheit: " + fahhrenheit.ToString("F1", CultureInfo.InvariantCulture));

                Console.WriteLine("Desejar repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            }
            while (repetir == 's');
        }
    }
}