using System;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Globalization;

namespace ExResolvido2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, altura, area, perimetro, diagonal;

            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * altura;
            perimetro = 2 * (b + altura);
            diagonal = Math.Sqrt(Math.Pow(altura, 2.0) + Math.Pow(b, 2.0));

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}