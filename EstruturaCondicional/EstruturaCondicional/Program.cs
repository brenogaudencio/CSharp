using System;

namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas;

            Console.WriteLine("Quantas horas são?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else {
                Console.WriteLine("Boa tarde");
            }

        }
    }
}