﻿using System;

namespace P11___CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11");

            Double valorInvestido = 1000;


            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após" + contadorMes + "meses, você terá R$" + valorInvestido);

            }





            Console.ReadLine();

        }
    }
}
