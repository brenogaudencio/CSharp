using System;
using System.Runtime.Serialization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, soma, x;
            int[] A;

            soma = 0;

            N = int.Parse(Console.ReadLine());
            A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    x = A[i];
                    Console.Write(x + " ");
                    soma++;
                }
            }
            Console.WriteLine("");
            Console.Write(soma);
        }
    }
}