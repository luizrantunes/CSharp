using System;

namespace Beecrowd1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo = Console.ReadLine();

            if (tipo == "vertebrado")
            {
                string tipo1 = Console.ReadLine();
                if (tipo1 == "ave")
                {
                    string tipo2 = Console.ReadLine();
                    if (tipo2 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (tipo2 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                    else
                    {
                        Console.WriteLine("invalido");
                    }
                }
                else if (tipo1 == "mamifero")
                {
                    string tipo2 = Console.ReadLine();
                    if (tipo2 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (tipo2 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                    else
                    {
                        Console.WriteLine("invalido");
                    }
                }
            }
            else if (tipo == "invertebrado")
            {
                string tipo1 = Console.ReadLine();
                if (tipo1 == "inseto")
                {
                    string tipo2 = Console.ReadLine();
                    if (tipo2 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (tipo2 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                    else
                    {
                        Console.WriteLine("invalido");
                    }
                }
                else if (tipo1 == "anelideo")
                {
                    string tipo2 = Console.ReadLine();
                    if (tipo2 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (tipo2 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                    else
                    {
                        Console.WriteLine("invalido");
                    }
                }
            }
            else
            {
                Console.WriteLine("inválido");
            }
            
        }
    }
}