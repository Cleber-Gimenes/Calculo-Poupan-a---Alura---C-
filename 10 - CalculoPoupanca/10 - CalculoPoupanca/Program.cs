using System;

namespace _10___CalculoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calculo Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while(contadorMes <=12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, voce terá R$" + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }





            Console.ReadLine();

        }
    }
}
