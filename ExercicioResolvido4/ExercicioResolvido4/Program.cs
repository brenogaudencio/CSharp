using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int segundosHora = 3600;

            int horas = numero / segundosHora;
            int minutos = (numero % segundosHora) / 60;
            int sec = (numero % segundosHora) % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + sec);
        }
    }
}