using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius, fahrenheit;
            char novoPrograma;

            do{
                Console.Write("Digite a temperatura em Celcius: ");
                celcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fahrenheit = (celcius * 9.0) / 5 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + fahrenheit.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                novoPrograma = char.Parse(Console.ReadLine());
            } while (novoPrograma == 's');
            
        }
    }
}