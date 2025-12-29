using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, p = 0; ;
            double[] nota1, nota2;
            string[] nomes, aprovados;
            double media = 0.0;

            N = int.Parse(Console.ReadLine());
            nomes = new string[N];
            nota1 = new double[N];
            nota2 = new double[N];
            aprovados = new string[N];
            

            for (int i = 0; i < N; i++) { 
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
                media = (nota1[i] + nota2[i]) / 2.0;

                if (media >= 6.0) {
                    aprovados[p] = nomes[i];
                    p++;
                }
            }
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(aprovados[i]);
            }
        }
    }
}