using System;
using System.Globalization;


namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            char z = 'F';
            int y = 39;
            string w = "Maria";



            Console.Write("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Meu nome é " + w + ", tenho " + y + " anos e sou do sexo " + z + ".");

            Console.WriteLine();
            Console.WriteLine("RESULTADO =  R$" + x);
            Console.WriteLine("O valor do troco é = R$" + x);
            Console.WriteLine("O valor do troco é = R$" + x.ToString("F2"));
        }
    }
}