﻿using System;

namespace Beecrowd1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int inicial = int.Parse(valores[0]);
            int final = int.Parse(valores[1]);
            int duracao = 0;

            if (inicial < final)
            {
                duracao = final - inicial;
            }
            else
            {
                duracao = 24 - inicial + final;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}