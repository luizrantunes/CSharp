using System;

namespace Aula08
{
    class program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int vezes = numero * i;
                Console.WriteLine(i + " x " + numero + " = " + vezes);
            }
        }
    }
}