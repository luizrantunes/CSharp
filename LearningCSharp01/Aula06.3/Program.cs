using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos, horas, restantes;

            segundos = int.Parse(Console.ReadLine());

            minutos = (segundos % 3600) / 60;
            horas = segundos / 3600;
            restantes = segundos % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + restantes);

        }
    }
}