using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, parada, x;

            parada = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x % 2 != 0)
                {
                    if (x < 0)
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                    else if (x > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else if (x % 2 == 0)
                {
                    if (x < 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else if (x > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                }
                parada = parada + 1;
            }
        }
    }
}