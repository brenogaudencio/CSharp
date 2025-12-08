using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = 0;
            y = 4;

            while (x < 3)
            {
                y = y + 2;
                x = x + 1;
                Console.WriteLine(x + "-" + y);
            }

        }
    }
};
