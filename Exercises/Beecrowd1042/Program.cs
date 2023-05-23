using System;

namespace Beecrowd1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            int[] numeros = { a, b, c };
            Array.Sort(numeros);

            int menor = numeros[0];
            int medio = numeros[1];
            int maior = numeros[2];

            
            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}