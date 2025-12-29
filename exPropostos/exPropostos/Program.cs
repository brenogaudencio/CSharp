using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, soma;
            double[] B;
            double x = 0.0;
            soma = 0;

            N = int.Parse(Console.ReadLine());
            B = new double[N];  

            for (int i = 0; i < N; i++)
            {
                B[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (x < B[i]) {
                    x = B[i];
                    soma++;
                }
            }
            Console.WriteLine(x.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(soma);
        }
    }
}