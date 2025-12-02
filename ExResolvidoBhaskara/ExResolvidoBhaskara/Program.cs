using System;
using System.Globalization;
using System.Security.Cryptography;

namespace ExBhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');

            double a, b, c, delta, r1, r2;

            a = double.Parse(vet[0], CultureInfo.InvariantCulture); 
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
              
            delta = (b * b) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Imposivel calcular");
            }
            else {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
} 