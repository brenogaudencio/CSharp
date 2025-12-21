using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, parada, dentro, fora;

            N = int.Parse(Console.ReadLine());
            parada = 0;
            dentro = 0;
            fora = 0;
            while (parada < N){
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro = dentro + 1;
                }
                else {
                    fora = fora + 1;
                }
                parada = parada + 1;
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
} 