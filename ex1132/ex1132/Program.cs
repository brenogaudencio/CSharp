using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            int inicio = Math.Min(x, y);
            int fim = Math.Max(x, y);   
            soma = 0;

            for (int i = inicio; i <= fim ; i++)
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;   
                }
            }
            Console.WriteLine(soma);
        }
    }
}