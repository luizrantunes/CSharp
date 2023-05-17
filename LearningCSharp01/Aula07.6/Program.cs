using System;
using System.Globalization;

namespace Aula07
{
    class program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;
            
            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda-feira";
                    break;
                case 3:
                    dia = "terça-feira";
                    break;
                case 4:
                    dia = "quarta-feira";
                    break;
                case 5:
                    dia = "quinta-feira";
                    break;
                case 6:
                    dia = "sexta-feira";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default:
                    dia = "valor invalido";
                    break;
            }
            Console.WriteLine("Dia da semana: " + dia);
        }
    }
}