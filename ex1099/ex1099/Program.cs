using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, y;
            

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) { 
                string[] val = Console.ReadLine().Split(' ');
                x = int.Parse(val[0]);
                y = int.Parse(val[1]);  

                int max = Math.Max(x, y);
                int min = Math.Min(x, y);
                int soma = 0;
                for (int p = min + 1; p < max; p++) {
                    if (p % 2 != 0) {
                        soma += p;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}