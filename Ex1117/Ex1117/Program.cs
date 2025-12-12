using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Transactions;

namespace Ex1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0 || nota1 > 10) { //define os limites de validação das notas
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            }

            double nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0 || nota2 > 10) { //define os limites de validação das notas
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + media.ToString(), CultureInfo.InvariantCulture);
        }
    }
}