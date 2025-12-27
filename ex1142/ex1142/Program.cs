using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, j, k, l;
            j = 1;
            k = 2;
            l = 3;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine(j + " " + k + " " + l + " PUM");
                j += 4;
                k += 4;
                l += 4;
            }
        }
    }
}