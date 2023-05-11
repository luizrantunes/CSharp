using System;
using System.Globalization;

namespace Aula04
{
    class Programa
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] data = Console.ReadLine().Split(' ');

            string name = data[0];
            char gender = char.Parse(data[1]);
            int age = int.Parse(data[2]);
            double hight = double.Parse(data[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name);
            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(hight.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}