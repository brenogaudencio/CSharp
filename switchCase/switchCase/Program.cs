using System;
using System.Runtime;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda-feira";
                    break;
                case 3:
                    dia = "terça-feira";
                    break;
                case 4:
                    dia = "quarta-feira";
                    break;
                case 5: 
                    dia = "quinta-feira";
                    break;
                case 6:
                    dia = "sexta-feira";
                    break;  
                case 7: 
                    dia = "sábado";
                    break;
                default:
                    dia = "valor inválido";
                    break;
            }
            Console.WriteLine("Dia da semana: " + dia); 
        }
    }
}
