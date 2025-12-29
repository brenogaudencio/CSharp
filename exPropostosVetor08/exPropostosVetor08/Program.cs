using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, soma = 0, numHomens = 0;
            double mediaAltF, somaAlt = 0.0;
            double[] altura;
            char[] sexo;
            double maiorAlt = double.MinValue;
            double menorAlt = double.MaxValue;

            N = int.Parse(Console.ReadLine());
            altura = new double[N];
            sexo = new char[N];
            

            for (int i = 0; i < N; i++)
            {
                string[] strings = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(strings[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(strings[1]);

                if (altura[i] > maiorAlt)
                {
                    maiorAlt = altura[i];
                }
                else if (altura[i] < menorAlt)
                {
                    menorAlt = altura[i];
                }

                

                if (sexo[i] == 'F')
                {
                    somaAlt += altura[i];
                    soma++;
                }
                else if (sexo[i] == 'M') { 
                    numHomens++;
                }
            }
            mediaAltF = somaAlt / soma;
            Console.WriteLine("Menor altura = " + menorAlt.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maiorAlt.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + mediaAltF.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + numHomens);
        }
    }
}