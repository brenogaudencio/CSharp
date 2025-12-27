using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, n1, n2, n3;
            n1 = 1;
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {
                n2 = n1 * n1;
                n3 = n1 * n2;
                Console.WriteLine(n1 + " " + n2 + " " + n3);
                n1 += 1;
            }
        }
    }
}