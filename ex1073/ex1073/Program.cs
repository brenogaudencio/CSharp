using System;

namespace ex1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, E;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i<=N; i++) {
                if (i % 2 == 0) {
                    E = i * i;
                    Console.WriteLine(i + "^2 = " + E);
                }
            }
        }
    }
}