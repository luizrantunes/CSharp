using System;
using System.Globalization;

namespace Aula04
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double product = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Coloque seu último nome, idade e altura (na mesma linha)");
            string[] geral = Console.ReadLine().Split(' ');
            string firstname = geral[0];
            int age = int.Parse(geral[1]);
            double height = double.Parse(geral[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Meu nome é: " + name + ".");
            Console.WriteLine("Na minha casa tem " + rooms + " quartos.");
            Console.WriteLine("O valor do produto é R$" + product.ToString("F2", CultureInfo.InvariantCulture) + ".");
            Console.WriteLine("Em resumo, me chamo " + firstname + ", ");
            Console.WriteLine("tenho " + age + " anos ");
            Console.WriteLine("e meço " + height.ToString("F2", CultureInfo.InvariantCulture) + " de altura.");
        }
    }
}