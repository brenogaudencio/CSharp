using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, somar, cont, finalCont;


            idade = double.Parse(Console.ReadLine());
            somar = 0.0;
            cont = 0.0;

            while (idade >= 0)
            {
                somar = somar + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine());
            }
            if (cont == 0) {
                Console.WriteLine("Impossível calcular");
            }else { 
                finalCont = somar / cont;
                Console.WriteLine(finalCont.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}