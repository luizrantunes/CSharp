using System.Globalization;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();
            Funcionario b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            a.Nome = Console.ReadLine();
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            b.Nome = Console.ReadLine();
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.Salario + b.Salario) / 2;
            Console.WriteLine("Salário médio = " +  media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}