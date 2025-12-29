using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;
            double soma, media;
            soma = 0.0;

            N = int.Parse(Console.ReadLine());
            A = new double[N];  

            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma = soma + A[i];  
            }
            media = soma / (double)N;
            Console.WriteLine(media.ToString(CultureInfo.InvariantCulture));
            for (int i = 0; i < N; i++) {
                if (A[i] < media) {
                    Console.WriteLine(A[i].ToString("F1", CultureInfo.InvariantCulture));
                }         
            }
        }
    }
}