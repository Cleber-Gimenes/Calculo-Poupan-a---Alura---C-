using System;

namespace p13_forencadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando p13");
            //fazendo asteriscos com break
            for(int contadorLinha = 0; contadorLinha <10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna <10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();

            }
            //Uma nova maneira de fazer desenhos de asteriscos.
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                   
                }
                Console.WriteLine();

            }




            Console.ReadLine();
        }
    }
}
