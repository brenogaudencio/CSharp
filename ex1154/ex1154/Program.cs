using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, cont, somar, media;
            somar = 0.0;
            cont = 0.0;

            idade = double.Parse(Console.ReadLine());

            while (idade >= 0) {
                somar = somar + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine());
            }
            media = somar / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}