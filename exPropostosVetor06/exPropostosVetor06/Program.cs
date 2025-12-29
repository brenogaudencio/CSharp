using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;
            int[] idades;
            int N, x, p;
            x = 0;
            p = 0;

            N = int.Parse(Console.ReadLine());
            nomes = new string[N];
            idades = new int[N];
            

            for (int i = 0; i < N; i++) {
                string[] vetor = Console.ReadLine().Split(' ');
                nomes[i] = vetor[0];
                idades[i] = int.Parse(vetor[1]);

                if (x < idades[i]) {
                    x = idades[i];
                    p = i;  
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[p]);
        }
    }
}