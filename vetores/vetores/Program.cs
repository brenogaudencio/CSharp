using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] B;
            int N;

            N = int.Parse(Console.ReadLine());
            B = new double[N];

            for (int i = 0; i < N; i++)
            {
                B[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++) {
                Console.WriteLine(B[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}