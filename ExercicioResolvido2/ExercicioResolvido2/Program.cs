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
            double b, altura, area, perimetro, diagonal, x;

            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * altura;
            perimetro = 2 * (b + altura);
            x = (b * b) + (altura * altura);

            diagonal = Math.Sqrt(x);

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}