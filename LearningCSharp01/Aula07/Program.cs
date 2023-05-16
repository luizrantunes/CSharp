using System;

namespace Aula07
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que horas são?");
            int horas = int.Parse(Console.ReadLine());

            if (horas > 5 && horas < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (horas > 12 && horas < 18) {
                    Console.WriteLine("Boa tarde!");
            }
            else {
                    Console.WriteLine("Boa noite!");
            }
        }
    }
}