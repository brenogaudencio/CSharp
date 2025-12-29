using System;
using System.Globalization; 
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, soma, cont;
            int[] A;
            double media;
            soma = 0;
            cont = 0;
            media = 0.0;

            N = int.Parse(Console.ReadLine());
            A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                if (A[i] % 2 == 0) { 
                    soma = soma + A[i];
                    cont += 1;
                    
                }
            }
            media = (double)soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}