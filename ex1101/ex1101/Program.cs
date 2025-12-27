using System;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] val = Console.ReadLine().Split(' ');
                int m = int.Parse(val[0]);
                int n = int.Parse(val[1]);

                if (m <= 0 || n <= 0)
                    break;
                
                int max = Math.Max(m, n);
                int min = Math.Min(m, n);
                int soma = 0;

                for (int i = min; i <= max; i++)
                {
                    Console.Write(i);
                    if (i < max)
                    Console.Write(" ");
                    soma += i;
                }
                Console.WriteLine(" Sum=" + soma);
            }
        }
    }
}