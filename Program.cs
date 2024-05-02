using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("StopWatch application - Desenvolvido por Patrick Mendes Silva");
            Console.WriteLine("=============================================================");
            Console.WriteLine("Instruções de uso: ");
            Console.WriteLine("Digite o valor a ser contado + o seu modificador (s ou m)");
            Console.WriteLine("Para sair, digite 0s.");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("=============================================================");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dataTime = Console.ReadLine().ToLower();
            char dateType = char.Parse(dataTime.Substring(dataTime.Length - 1 ,1)); // utilizando substring padrão
            int time = int.Parse(dataTime[..^1]); //utilizando range operator
            int multiplier = 1;

            if (dateType == 'm')
                multiplier = 60;
            
            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);

            Menu();
        }
    }
}