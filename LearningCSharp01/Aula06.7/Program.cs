using System;
using System.Globalization;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());

            int tempo = ((distancia * 60) / (90 - 60));
            
            Console.WriteLine(tempo + " minutos");
        }
    }
}