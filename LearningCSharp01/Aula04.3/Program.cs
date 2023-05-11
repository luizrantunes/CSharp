using System;
using System.Globalization;

namespace Aula04
{
    class Programa
    {
        static void Main(string[] args)
        {
            double largura, comprimento, preco, area, valor;

            Console.WriteLine("Qual é a largura do terreno por m²?");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual é o comprimento do terreno por m²?");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual é o preço por m²?");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            valor = area * preco;

            Console.WriteLine("A área total tem " + area.ToString("F2", CultureInfo.InvariantCulture) + " m².");
            Console.WriteLine("E o valor total do preço por m² é de R$" + valor.ToString("F2", CultureInfo.InvariantCulture) + ".");
        }
    }
}