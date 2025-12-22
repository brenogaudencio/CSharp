using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, cobaias, totalS, totalC, totalR, totalCobaias;
            double porcentagemC, porcentagemR, porcentagemS;
            char c, s, r, soma;

            totalC = 0;
            totalR = 0;
            totalS = 0;
            totalCobaias = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] cob = Console.ReadLine().Split(' ');
                cobaias = int.Parse(cob[0]);
                soma = char.Parse(cob[1]);

                if (soma == 'C')
                {
                    totalC = totalC + cobaias;
                }
                else if (soma == 'S')
                {
                    totalS = totalS + cobaias;
                }
                else if (soma == 'R')
                {
                    totalR = totalR + cobaias;
                }
                totalCobaias = totalCobaias + cobaias;
            }
            porcentagemC = (totalC * 100.0) / totalCobaias;
            porcentagemR = (totalR * 100.0) / totalCobaias;
            porcentagemS = (totalS * 100.0) / totalCobaias;
            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalC);
            Console.WriteLine("Total de ratos: " + totalR);
            Console.WriteLine("Total de sapos: " + totalS);
            Console.WriteLine("Percentual de coelhos: " + porcentagemC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemS.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}