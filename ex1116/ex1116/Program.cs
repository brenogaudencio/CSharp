using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, y;
            double divisao; 
            

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                string[] val = Console.ReadLine().Split(' ');
                x = int.Parse(val[0]);
                y = int.Parse(val[1]);

                divisao = (double) x / y;

                if (y == 0.0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}