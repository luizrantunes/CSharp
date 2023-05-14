using System;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionarioID, horasTrabalhadas;
            double valorHora, salario;

            funcionarioID = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + funcionarioID);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}