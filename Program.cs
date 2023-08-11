using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu();
        }

        static void PreStart()
        {
            
            for (int i = 3; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("começando...");
            Thread.Sleep(1500);
            
        }
        static void Start(int tempo)
        {
            PreStart();
            int tempoAtual = 0;
            while (tempo != tempoAtual)
            {
                Console.Clear();
                tempoAtual++;
                if (tempoAtual < 60)
                {
                    Console.WriteLine("\n" + tempoAtual + "\n");
                }
                else
                {
                    int minutos = tempoAtual / 60;
                    int segundos = tempoAtual % 60;
                    if (segundos < 10)
                    {
                        Console.WriteLine($"\n{minutos}:0{segundos}\n");

                    }
                    else
                    {
                        Console.WriteLine($"\n{minutos}:{segundos}\n");
                    }
                }
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("\nFIM DO TEMPO !!!\n");
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("\nCRONOMETRO\n");
            Console.WriteLine("Qual o limite de tempo em segundos?\n\nDigite `0` para sair!!!\n\n");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 0)
            {
                System.Environment.Exit(0);
            }

            Start(valor);
        }
    }
}