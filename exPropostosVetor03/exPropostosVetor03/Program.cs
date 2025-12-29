using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A, B, C;

            N = int.Parse(Console.ReadLine());
            A = new int[N];
            B = new int[N];
            C = new int[N];
            for (int i = 0; i < N; i++) { 
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++) { 
                B[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++) { 
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }
            
        }
    }
}