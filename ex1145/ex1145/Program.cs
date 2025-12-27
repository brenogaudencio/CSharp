using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] val = Console.ReadLine().Split(' ');
            x = int.Parse(val[0]);
            y = int.Parse(val[1]);

            int min = Math.Min(x, y);
            int max = Math.Max(x, y);

            for (int i = 1; i <= max; i++) {
                if (i % x != 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}