using System;

using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double nota1, nota2, nota3;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] val = Console.ReadLine().Split(' ');
                nota1 = double.Parse(val[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(val[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(val[2], CultureInfo.InvariantCulture);
                double mediaPonderada = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/ 10.0;
                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}