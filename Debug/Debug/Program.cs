using System;
using System.Globalization;

namespace Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, precoTotal;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            area = largura * comprimento;
            precoTotal = precoMetroQuadrado * area;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco = " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}