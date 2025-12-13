using System;

namespace Ex1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            int num = int.Parse(Console.ReadLine());
            while (num != 4)
            {
                if (num == 1)
                {
                    alcool++;
                }
                else if (num == 2)
                {
                    gasolina++;
                }
                else if (num == 3)
                {
                    diesel++;
                }
                
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
